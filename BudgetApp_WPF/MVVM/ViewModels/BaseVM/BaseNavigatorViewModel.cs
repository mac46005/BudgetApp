using BudgetApp_WPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    internal class BaseNavigatorViewModel<T> : ObservableObject, INavigator<T>
    {
        public IViewModel<T> CurrentViewModel { get; set; }
        public ICommand UpdateCurrentViewModelICommand { get; set; }
        public T Model { get; set; }
    }
}
