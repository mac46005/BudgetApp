using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.Core.Commands
{
    interface IGenerateDataManipulationViewCommand<T, U> : ICommand where T : BaseModel<U>
    {
        
    }
}
