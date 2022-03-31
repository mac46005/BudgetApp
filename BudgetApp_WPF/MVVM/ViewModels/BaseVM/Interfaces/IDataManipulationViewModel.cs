using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Commands.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces
{
    internal interface IDataManipulationViewModel<T,U> : IViewModel<T> where T : BaseModel<U>
    {
        IManipulateDataCommand<T,U> ManipulateDataCommand { get; }
    }
}
