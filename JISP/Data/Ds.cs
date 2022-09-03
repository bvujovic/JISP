using JISP.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace JISP.Data
{
    partial class Ds
    {
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

        public partial class UceniciRow
        {
            public void CalcDatRodjBasedData()
            {
                if (!IsDatumRodjenjaNull())
                {
                    DanaDoRodj = JMBG.DaysToBDay(DatumRodjenja);
                    Godine = JMBG.YearsOld(DatumRodjenja);
                }
            }

            public bool JeOsnovac
                => !IsSkolaNull() && Skola == "Основна";

            public bool JeSrednjoskolac
                => !IsSkolaNull() && Skola == "Средња";

            public override string ToString()
                => $"{Ime}, JOB: {JOB}";
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
                => $"{Ime} {Prezime}";
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
