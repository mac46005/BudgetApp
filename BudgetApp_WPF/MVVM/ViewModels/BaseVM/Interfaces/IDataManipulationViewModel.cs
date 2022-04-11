using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Commands.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces
{
    internal interface IDataManipulationViewModel<T,U> : IViewModel<T> where T : BaseModel<U>
    {
        //Maybe use an event?
        // TODO create a Custom even arg to take generic item
        event EventHandler ViewModelResolvedEvent;
        ICommand RelayCommand { get; }
    }
}
