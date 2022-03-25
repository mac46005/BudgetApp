using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.Models
{
    public class Expense_SubCategory : IModel<int>
    {
        public int ID { get; set; }
        public int ExpenseCategory_ID { get; set; }
        public string Name { get; set; }
    }
}
