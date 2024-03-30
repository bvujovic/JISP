using JISP.Classes;
using JISP.Classes.SumaZaposlenja;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace JISP.Data
{
    partial class Ds
    {
        partial class SumZaposlenjaDataTable
        {
            /// <summary>Sumiranje/grupisanje zaposlenja u ŠOSO Sv. Sava</summary>
            public void SumZaposlenjaUSkoli(ZaposleniRow zap, DateTime datumDo)
            {
                // uklanjanje prethodno izračunatih sum-zaposlenja u ŠOSO Sv. Sava
                var ds = this.DataSet as Ds;
                var sumNja = this.Where(it => it.IdZaposlenog == zap.IdZaposlenog
                    && it.IdTipaPoslodavca == TipoviPoslodavacaDataTable.SvetiSava.IdTipaPosl).ToList();
                foreach (var it in sumNja)
                    ds.SumZaposlenja.RemoveSumZaposlenjaRow(it);

                var l = new ListaSumZap();
                foreach (var nje in zap.GetZaposlenjaRows().Where(it => it.DatumZaposlenOd < datumDo &&
                    (it.IsRazlogPrestankaZaposlenjaNull() || !it.RazlogPrestankaZaposlenja.Contains("Техничка грешка"))))
                {
                    var sz = new SumZap();
                    sz.IDs.Add(nje.IdZaposlenja);
                    sz.DatumOd = nje.DatumZaposlenOd;
                    if (nje.IsDatumZaposlenDoNull())
                        sz.DatumDo = datumDo;
                    else
                        sz.DatumDo = nje.DatumZaposlenDo;
                    sz.ProcenatAng = nje.ProcenatRadnogVremena;
                    l.Dodaj(sz);
                }
                l.Sumiraj();

                foreach (var x in l.SumZaps)
                {
                    var sz = NewSumZaposlenjaRow();
                    sz.ZaposleniRow = zap;
                    sz.DatumOd = x.DatumOd;
                    sz.DatumDo = x.DatumDo;
                    sz.ProcenatAngazovanja = x.ProcenatAng;
                    try
                    {
                        var staz = Staz.Razlika(sz.DatumOd, sz.DatumDo);
                        sz.Staz = staz.ToString();
                        if (staz.Equals(Datum.JedanDan))
                            sz.Napomene = "Staz od samo jednog dana.";
                    }
                    catch (Exception ex)
                    {
                        sz.Staz = "/";
                        sz.Napomene = ex.Message;
                    }
                    sz.TipoviPoslodavacaRow = TipoviPoslodavacaDataTable.SvetiSava;
                    //TODO dodati redove u SumZapDetalji i prikazati ih u dgvSumZapDetalji
                    AddSumZaposlenjaRow(sz);
                }
            }

            /// <summary>Uklanjanje prethodno izračunatih sum-zaposlenja u ŠOSO Sv. Sava.</summary>
            public void ObrisiZaSosoSvetiSava()
            {
                var c = this.Where(it => it.IdTipaPoslodavca == TipoviPoslodavacaDataTable.SvetiSava.IdTipaPosl)
                    .ToList();
                foreach (var it in c)
                    (DataSet as Ds).SumZaposlenja.RemoveSumZaposlenjaRow(it);
            }
        }

        partial class TipoviPoslodavacaDataTable
        {
            /// <summary>Naša škola.</summary>
            private readonly static string TipSosoSvetiSava = "ŠOSO Sveti Sava";
            /// <summary>Sve škole osim ŠOSO Sveti Sava.</summary>
            private readonly static string TipObrazovanje = "Obrazovanje";
            /// <summary>Svi poslodavci van obrazovnog sistema.</summary>
            private readonly static string TipVanObrazovanja = "Van obrazovanja";

            /// <summary>Naša škola.</summary>
            public static TipoviPoslodavacaRow SvetiSava;
            /// <summary>Sve škole osim ŠOSO Sveti Sava.</summary>
            public static TipoviPoslodavacaRow Obrazovanje;
            /// <summary>Svi poslodavci van obrazovnog sistema.</summary>
            public static TipoviPoslodavacaRow VanObrazovanja;

            /// <summary>Unos svih neophodnih tipova poslodavaca za zaposlene.</summary>
            public void DataInit()
            {
                if (Count == 0)
                {
                    AddTipoviPoslodavacaRow(TipSosoSvetiSava);
                    AddTipoviPoslodavacaRow(TipObrazovanje);
                    AddTipoviPoslodavacaRow(TipVanObrazovanja);
                }
                SvetiSava = this.FirstOrDefault(it => it.NazivTipaPosl == TipSosoSvetiSava);
                Obrazovanje = this.FirstOrDefault(it => it.NazivTipaPosl == TipObrazovanje);
                VanObrazovanja = this.FirstOrDefault(it => it.NazivTipaPosl == TipVanObrazovanja);
            }
        }

        partial class ObracunZaradaRow
        {
            /// <summary>Ukupan broj meseci po formuli: 12*Godina + MesecBroj</summary>
            public int MeseciTotal
                => Godina * 12 + MesecBroj;
        }

        partial class UceniciDataTable
        {
            protected override void OnColumnChanged(DataColumnChangeEventArgs e)
            {
                base.OnColumnChanged(e);
                if (e.Column.Ordinal == DatumRodjenjaColumn.Ordinal)
                    (e.Row as UceniciRow).CalcDatRodjBasedData();
            }

            public void CalcDatRodjBasedCols()
            {
                foreach (UceniciRow uc in this.Rows)
                    uc.CalcDatRodjBasedData();
            }
        }

        public partial class UcenikSkGodRow
        {
            public bool JePredskolac
                => !IsSkolaNull() && Skola == "Вртић";

            public bool JeOsnovac
                => !IsSkolaNull() && Skola == "Основна";

            public bool JeSrednjoskolac
                => !IsSkolaNull() && Skola == "Средња";

            public override string ToString()
                => $"{_Ime}, JOB: {_JOB}, Razred: {Razred}";
        }

        public partial class UceniciRow
        {
            public void CalcDatRodjBasedData()
            {
                if (!IsDatumRodjenjaNull())
                {
                    DanaDoRodj = Classes.JMBG.DaysToBDay(DatumRodjenja);
                    Godine = Classes.JMBG.YearsOld(DatumRodjenja);
                }
            }

            public override string ToString()
                => $"{(!IsUcenikStringNull() ? UcenikString : "/")}, JOB: {JOB}";
        }

        partial class ZaposleniDataTable
        {
            protected override void OnColumnChanged(DataColumnChangeEventArgs e)
            {
                base.OnColumnChanged(e);
                if (e.Column.Ordinal == JMBGColumn.Ordinal)
                    (e.Row as ZaposleniRow).CalcJmbgBasedData();
            }

            public void CalcJmbgBasedCols()
            {
                foreach (ZaposleniRow zap in this.Rows)
                    zap.CalcJmbgBasedData();
            }

            /// <summary>
            /// Upisivanje podataka u kolonu Aktivan.
            /// Zaposleni je aktivan ako ima bar jedno aktivno zaposlenje.
            /// </summary>
            public void CalcAktivan()
            {
                foreach (ZaposleniRow zap in this.Rows)
                    zap.Aktivan = zap.GetZaposlenjaRows().Any(it => it.Aktivan);
            }
        }

        public partial class ZaposleniRow
        {
            public void CalcJmbgBasedData()
            {
                if (IsJMBGNull())
                    return;
                if (Classes.JMBG.IsValid(JMBG))
                {
                    var bdate = Classes.JMBG.GetBirthDate(JMBG);
                    DanaDoRodj = Classes.JMBG.DaysToBDay(bdate);
                    Godine = Classes.JMBG.YearsOld(bdate);
                }
            }

            /// <summary>Sastavlja tekst koji opisuje finansiranje, norme i predmete za sva angazovanja zap.</summary>
            public void CalcAngazovanja()
            {
                try
                {
                    var angs = new List<string>();
                    foreach (var zap in GetZaposlenjaRows().Where(it => it.Aktivan))
                    {
                        foreach (var ang in zap.GetAngazovanjaRows()
                            .Where(it => it.SkolskaGodina == AppData.SkolskaGodina.Naziv))
                        {
                            var strAng = "";
                            var predmet = !ang.IsPredmetNull() ? ang.Predmet : "";
                            predmet += !ang.IsPodnivoPredmetaNull() ? ", " + ang.PodnivoPredmeta : "";

                            var posao = Utils.SuperSkratiIzvorFin(ang.IzvorFinansiranja)
                                + ": " + ang.ProcenatAngazovanja + "%";
                            if (predmet != "")
                                posao += " - " + predmet;

                            strAng += posao + Environment.NewLine;
                            angs.Add(posao);
                        }
                    }
                    Angazovanja = string.Join(Environment.NewLine, angs);
                }
                catch { Angazovanja = string.Empty; }
            }

            public override string ToString()
                => ZaposleniString;
        }

        partial class ZaposlenjaRow
        {
            /// <summary>true - VrstaAngazovanja je neka zamena, a nije unet zamenjeni zaposleni.</summary>
            /// <remarks>Ispitivanje postojanja unosa zamenjenog zaposlenog se vrši samo za tekuću šk. god.</remarks>
            public bool NedostajeZamenjeni
                => AppData.SkolskaGodina.PripadaDatum(DatumZaposlenOd) &&
                    VrstaAngazovanja.Contains("замена") && IsIdZamenjenogZaposlenogNull();
        }

        //partial class ZaposlenjaDataTable
        //{
        //    protected override void OnTableNewRow(DataTableNewRowEventArgs e)
        //    {
        //        base.OnTableNewRow(e);
        //        var zaposleni = e.Row.GetParentRow("FK_Zaposleni_Zaposlenja") as ZaposleniRow;
        //        zaposleni.CalcAngazovanja();
        //    }
        //}

        //partial class AngazovanjaDataTable
        //{
        //    protected override void OnTableNewRow(DataTableNewRowEventArgs e)
        //    {
        //        base.OnTableNewRow(e);
        //        var zaposleni = e.Row.GetParentRow("Zaposlenja_Angazovanja").GetParentRow("FK_Zaposleni_Zaposlenja")
        //            as ZaposleniRow;
        //        zaposleni.CalcAngazovanja();
        //    }
        //}
    }
}
