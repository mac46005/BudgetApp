using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.Core.Commands.Interfaces
{
    internal interface IAddUpdateDataCommand<T,U> : ICommand where T : BaseModel<U>
    {
        IAPIEndpoint<T,U> APIEndPoint { get; }
        DataManipulationOptions Option { get; }

    }
}
