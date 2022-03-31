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
    internal abstract class BaseDeleteViewModel<T> : BaseViewModel<T>, IDeleteViewModel<T>
    {
        public BaseDeleteViewModel(T model)
        {
            Model = model;
        }
        public ICommand DeleteViewCommand { get; }
    }
}
