using BudgetApp_WPF.Core;
using BudgetApp_WPF.Core.Commands;
using BudgetApp_WPF.Core.Factories;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using BudgetApp_WPF.MVVM.ViewModels.NavigationVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        public ObservableCollection<object> DataCollection { get; set; }
        public INavigator<object> Navigator { get; set; }



        public MainViewModel(MainVM_NavigationViewModel mainNavigationViewModel)
        {
            Navigator = mainNavigationViewModel;
        }
    }
}
