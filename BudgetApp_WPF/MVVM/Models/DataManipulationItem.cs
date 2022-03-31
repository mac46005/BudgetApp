using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.Models
{
    public class DataManipulationItem<T,U> : where T : BaseModel<U>
    {
        public T Model { get; set; }
        public DataManipulationOptions Option { get; set; }
    }
}
