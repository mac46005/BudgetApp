using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.MVVM.Models;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.Core.Commands.Base.Interfaces
{
    internal interface IManipulateDataCommand<T, U> : ICommand where T : BaseModel<U>
    {
        T Model { get; }
        IAPIEndpoint<T, U> APIEndPoint { get; }
        DataManipulationOptions Option { get; }
        DataManipulationItem<T, U> DataManipulationItem { get; }
    }
}
