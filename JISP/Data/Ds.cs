using JISP.Classes;
using System.Data;
using System.Linq;

namespace JISP.Data
{
    partial class Ds
    {
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

            public override string ToString()
                => $"{Ime} {Prezime}";
        }
    }
}
