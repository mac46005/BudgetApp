using BudgetApp_WPF.MVVM.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels.Base.Navigators
{
    internal class BaseNavigatorViewModel<T, U> : BaseViewModel<U>, INavigator<T>
    {
        public BaseViewModel<T> CurrentViewModel { get; set; }

        public ICommand UpdateCurrentViewModelICommand { get; set; }
    }
}
