using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.Models
{
    public class IncomeItem : BaseModel<long>
    {
        public long ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int IncomeCategory_ID { get; set; }
        public Income_Category IncomeCategory { get; set; }
        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsReOccurring { get; set; }
        public BudgetFrequency BudgetFrequency { get; set; } = BudgetFrequency.OneTime;
        public string Note { get; set; } = string.Empty;
        public override string ToString()
        {
            return base.ToString() + $"\nPerson: {User.FirstName}\nIncomeCategory: {IncomeCategory.Name}\nAmount: {Amount.ToString("D")}\nTimeStamp: {this.TimeStamp.ToString("f")}\nFrequency: {BudgetFrequency.ToString()}\nNote: {Note}";
        }

        //Same thoughts about this like the expense item. :)//
    }
}
