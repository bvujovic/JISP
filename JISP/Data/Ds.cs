using JISP.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace JISP.Data
{
    partial class Ds
    {
        partial class RazrediDataTable
        {
            protected override void OnColumnChanged(DataColumnChangeEventArgs e)
            {
                base.OnColumnChanged(e);
                if (e.Column.Ordinal == NazivRazredaColumn.Ordinal)
                    (e.Row as RazrediRow).SortBroj = Utils.RazredSortBroj((string)e.ProposedValue);
            }
        }

        partial class RazrediRow
        {
            public override string ToString()
                => $"{NazivRazreda}, {SkolskaGodina}";
        }

        partial class OdeljenjaRow
        {
            public override string ToString()
                => $"{NazivOdeljenja}, {Staresina}";
        }

        partial class SumZaposlenjaDataTable
        {
            public void SumZaposlenjaUSkoli(ZaposleniRow zap, DateTime datumDo)
            {
                ObrisiZaSosoSvetiSava();
                var ds = this.DataSet as Ds;
                // odredjivanje opsega datuma svih validnih zaposlenja
                var nja = zap.GetZaposlenjaRows().Where(it => it.DatumZaposlenOd < datumDo &&
                    (it.IsRazlogPrestankaZaposlenjaNull() || !it.RazlogPrestankaZaposlenja.Contains("Техничка грешка")))
                    .ToList();
                var datumOd = nja.Where(it => !it.IsDatumZaposlenOdNull()).Min(it => it.DatumZaposlenOd);
                if (!nja.Any(it => it.Aktivan))
                {
                    var ddo = nja.Where(it => !it.Aktivan).Max(it => it.DatumZaposlenDo);
                    if (ddo < datumDo)
                        datumDo = ddo;
                }
                // prolazak kroz sve datume u opsegu i odredjivanje sum zaposlenja
                var szPrev = SumZapNaDan(datumOd, nja);
                for (var d = datumOd.AddDays(1); d <= datumDo; d = d.AddDays(1))
                {
                    var szCurr = SumZapNaDan(d, nja);
                    if (!SumZapMin.Isti(szCurr, szPrev))
                    {
                        if (szPrev.ProcenatAng > 0)
                            AddSumZap(zap, szPrev, d.AddDays(-1));
                        szPrev = szCurr;
                    }
                }
                AddSumZap(zap, szPrev, datumDo);
            }

            private void AddSumZap(ZaposleniRow zap, SumZapMin sz, DateTime datumDo)
            {
                var ds = this.DataSet as Ds;
                var sumZap = ds.SumZaposlenja.NewSumZaposlenjaRow();
                sumZap.ZaposleniRow = zap;
                sumZap.ProcenatAngazovanja = sz.ProcenatAng;
                sumZap.DatumOd = sz.DatumOd;
                sumZap.DatumDo = datumDo;
                var staz = Staz.Razlika(sumZap.DatumOd, sumZap.DatumDo);
                sumZap.Staz = staz.ToString();
                if (staz.Equals(Datum.JedanDan))
                    sumZap.Napomene = "Staz od samo jednog dana.";
                sumZap.TipoviPoslodavacaRow = TipoviPoslodavacaDataTable.SvetiSava;
                ds.SumZaposlenja.AddSumZaposlenjaRow(sumZap);

                foreach (var id in sz.IDs)
                {
                    var det = ds.SumZapDetalji.NewSumZapDetaljiRow();
                    det.SumZaposlenjaRow = sumZap;
                    det.ZaposlenjaRow = ds.Zaposlenja.FindByIdZaposlenja(id);
                    ds.SumZapDetalji.AddSumZapDetaljiRow(det);
                }
            }

            class SumZapMin
            {
                public DateTime DatumOd { get; set; }
                public HashSet<int> IDs { get; set; } = new HashSet<int>();
                public double ProcenatAng { get; set; }
                public SumZapMin(DateTime datumOd, List<int> ids, double procAng)
                {
                    DatumOd = datumOd;
                    foreach (var id in ids)
                        IDs.Add(id);
                    //IDs = ids;
                    ProcenatAng = procAng;
                }
                public static bool Isti(SumZapMin a, SumZapMin b)
                {
                    //B return a.ProcenatAng == b.ProcenatAng && a.IDs.Equals(b.IDs);
                    if (a.ProcenatAng != b.ProcenatAng)
                        return false;
                    if (a.IDs.Count != b.IDs.Count)
                        return false;
                    foreach (var id in a.IDs)
                        if (!b.IDs.Contains(id))
                            return false;
                    return true;
                }
                public override string ToString()
                    => $"{ProcenatAng:000}%, {DatumOd:yyyy-MM-dd}, IDs: [{string.Join(", ", IDs)}]";
            }

            private SumZapMin SumZapNaDan(DateTime dt, IEnumerable<ZaposlenjaRow> nja)
            {
                var njaNaDan = nja.Where(it => it.DatumZaposlenOd <= dt
                    && (it.IsDatumZaposlenDoNull() || dt <= it.DatumZaposlenDo));
                return new SumZapMin(dt, njaNaDan.Select(it => it.IdZaposlenja).ToList(),
                    njaNaDan.Sum(it => it.ProcenatRadnogVremena));
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
