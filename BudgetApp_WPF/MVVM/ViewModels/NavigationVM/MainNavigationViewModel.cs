using BudgetApp_WPF.Core.Commands;
using BudgetApp_WPF.Core.Factories;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.NavigationVM
{
    internal class MainNavigationViewModel : BaseNavigatorViewModel<object>
    {
        public MainNavigationViewModel(MainNavViewModelFactory mainNavViewModelFactory)
        {
            UpdateCurrentViewModelICommand = new HomeMainMenuOptionCommand(this, mainNavViewModelFactory);
        }
    }
}
