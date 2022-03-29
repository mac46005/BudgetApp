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
        public int UserID { get; set; }
        public User User { get; set; }
        public int ExpenseCategory_ID { get; set; }
        public Expense_Category Expense_Category { get; set; }
        public int ExpenseSubCategory_ID { get; set; }
        public Expense_SubCategory Expense_SubCategory { get; set; }
        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsReOccurring { get; set; } = false;
        public BudgetFrequency BudgetFrequency { get; set; } = BudgetFrequency.OneTime;
        public string ReferenceNumber { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public override string ToString()
        {
            return base.ToString() + $"\nUser: {User.FirstName}\nExpense Category: {Expense_Category.Name}\nExpense SubCategory: {Expense_SubCategory.Name}\nAmount: {Amount.ToString("D")}\nTimeStamp: {this.TimeStamp.ToString("f")}Budget Frequency: {BudgetFrequency.ToString()}\nReference Number: {ReferenceNumber}\nNote: {Note}";
        }
        //I love how detailed this is. Definitley will make it easy for us to find our expense item//
    }
}
