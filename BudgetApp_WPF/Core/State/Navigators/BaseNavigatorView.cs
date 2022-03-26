using BudgetApp_WPF.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.Core.State.Navigators
{
    internal class BaseNavigatorView<T> : ObservableObject, INavigator<T>
    {
        public BaseViewModel<T> CurrentViewModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICommand UpdateCurrentViewModelICommand => throw new NotImplementedException();
    }
}
