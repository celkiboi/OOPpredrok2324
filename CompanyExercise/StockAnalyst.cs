using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExercise;

public static class StockAnalyst
{
    public static DrasticYears FindDrasticYears(Dictionary<int, Company> yearlyReports)
    {
        KeyValuePair<int, Company> bestYear = yearlyReports.MaxBy(x => x.Value.StockValue);
        KeyValuePair<int, Company> worstYear = yearlyReports.MinBy(x => x.Value.StockValue);

        return new(bestYear.Key, worstYear.Key);
    }
}
