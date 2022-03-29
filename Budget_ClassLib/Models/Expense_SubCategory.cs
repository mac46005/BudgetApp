using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.Models
{
    public class Expense_SubCategory : BaseModel<int>
    {
        public int ID { get; set; }
        public int ExpenseCategory_ID { get; set; }
        public Expense_Category Expense_Category { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\nExpense Category: {Expense_Category.Name}\nName: {Name}";
        }
    }
}
