using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.Models
{
    public class BudgetSummary
    {

        public decimal TotalIncome { get; set; }
        public decimal TotalExpenses { get; set; }
        public string DebtToIncomeRatio
        {
            get
            {
                decimal debtToIncomeRatio = (TotalExpenses / TotalIncome) * 100; //mulitplying by 100 is a good idea. Better than a deecimal :)//
                return debtToIncomeRatio.ToString("P");
            }
        }


    }
}
