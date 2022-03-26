using BudgetApp_WPF.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.Core.State.Navigators
{
    internal class BaseNavigatorViewModel<T> : ObservableObject, INavigator<T>
    {
        public BaseViewModel<T> CurrentViewModel { get; set; }

        public ICommand UpdateCurrentViewModelICommand { get; set; }
    }
}
