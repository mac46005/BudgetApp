using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.Models
{
    public class IncomeItem
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int IncomeCategory_ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsReOccurring { get; set; }
        public BudgetFrequency BudgetFrequency { get; set; } = BudgetFrequency.OneTime;
        public string Note { get; set; } = string.Empty;

    }
}
