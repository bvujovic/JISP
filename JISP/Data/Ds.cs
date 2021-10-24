using System.Data;

namespace JISP.Data
{
    partial class Ds
    {
        partial class ZaposleniDataTable
        {
            protected override void OnColumnChanged(DataColumnChangeEventArgs e)
            {
                base.OnColumnChanged(e);
                if (e.Column.ColumnName == JMBGColumn.ColumnName)
                {
                    var row = e.Row as ZaposleniRow;
                    var jmbg = (string)e.ProposedValue;
                    if (Classes.JMBG.IsValid(jmbg))
                    {
                        var bdate = Classes.JMBG.GetBirthDate(jmbg);
                        row.DanaDoRodj = Classes.JMBG.DaysToBDay(bdate);
                        row.Godine = Classes.JMBG.YearsOld(bdate);
                    }
                }
            }
        }
    }
}
