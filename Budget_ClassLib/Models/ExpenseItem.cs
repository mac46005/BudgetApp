using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.Models
{
    public class ExpenseItem : BaseModel<long>
    {
        public long ID { get; set; }
        public int PersonID { get; set; }
        public int ExpenseCategory_ID { get; set; }
        public int ExpenseSubCategory_ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsReOccurring { get; set; } = false;
        public BudgetFrequency BudgetFrequency { get; set; } = BudgetFrequency.OneTime;
        public string ReferenceNumber { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        //I love how detailed this is. Definitley will make it easy for us to find our expense item//
    }
}
