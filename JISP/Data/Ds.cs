using JISP.Classes;
using System.Data;

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
        }
    }
}
