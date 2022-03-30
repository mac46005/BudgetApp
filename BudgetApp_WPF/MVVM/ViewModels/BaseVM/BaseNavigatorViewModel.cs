using BudgetApp_WPF.Core;
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
    internal abstract class BaseNavigatorViewModel<T> : BaseViewModel<T>,INavigator<T>
    {
        private object _ViewModel;
        public object ViewModel{
            get
            {
                return _ViewModel;
            }

            set
            {
                _ViewModel = value;
                OnPropertyChanged("ViewModel");
            }
        }
        public ICommand UpdateCurrentViewModelICommand { get; set; }
    }
}
