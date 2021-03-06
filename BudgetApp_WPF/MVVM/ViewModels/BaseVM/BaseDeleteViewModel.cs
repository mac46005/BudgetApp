using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Commands.Base.Interfaces;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    internal abstract class BaseDeleteViewModel<T,U> : BaseViewModel<T>, IDeleteViewModel<T,U> where T : BaseModel<U>
    {
        public BaseDeleteViewModel(T model)
        {
            Model = model;
        }

        public IManipulateDataCommand<T, U> ManipulateWindowCommand { get; }

        public ICommand RelayCommand => throw new NotImplementedException();

        public event EventHandler<T> ViewResolvedEvent;

        event EventHandler IDataManipulationViewModel<T, U>.ViewModelResolvedEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }
    }
}
