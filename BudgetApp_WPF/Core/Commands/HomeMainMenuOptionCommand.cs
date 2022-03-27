using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories;
using BudgetApp_WPF.MVVM.ViewModels;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using BudgetApp_WPF.MVVM.ViewModels.Category;
using BudgetApp_WPF.MVVM.ViewModels.Expense;
using BudgetApp_WPF.MVVM.ViewModels.History;
using BudgetApp_WPF.MVVM.ViewModels.Income;
using BudgetApp_WPF.MVVM.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.Core.Commands
{
    internal class HomeMainMenuOptionCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;




        private readonly INavigator<object> _navigator;
        private readonly MainNavViewModelFactory _mainNavVewModelFactory;



        ///





        public HomeMainMenuOptionCommand(INavigator navigator, MainNavViewModelFactory mainNavViewModelFactory)
        {
            _navigator = navigator;
            _mainNavVewModelFactory = mainNavViewModelFactory;
        }






        public bool CanExecute(object? parameter)
        {
            return true;
        }







        public void Execute(object? parameter)
        {
            if (parameter is MainMenuOptionsEnum)
            {
                MainMenuOptionsEnum mainMenuOptions = (MainMenuOptionsEnum)parameter;
                switch (mainMenuOptions)
                {
                    case MainMenuOptionsEnum.Current:
                        _navigator.CurrentViewModel = _mainNavVewModelFactory.CreateViewModel(mainMenuOptions);
                        break;
                    case MainMenuOptionsEnum.Goal:
                        _navigator.CurrentViewModel = _mainNavVewModelFactory.CreateViewModel(mainMenuOptions);
                        break;
                    case MainMenuOptionsEnum.History:
                        _navigator.CurrentViewModel = _mainNavVewModelFactory.CreateViewModel(mainMenuOptions);
                        break;
                    case MainMenuOptionsEnum.Income:
                        _navigator.CurrentViewModel = _mainNavVewModelFactory.CreateViewModel(mainMenuOptions);
                        break;
                    case MainMenuOptionsEnum.Expense:
                        _navigator.CurrentViewModel = _mainNavVewModelFactory.CreateViewModel(mainMenuOptions);
                        break;
                    case MainMenuOptionsEnum.Category:
                        _navigator.CurrentViewModel = _mainNavVewModelFactory.CreateViewModel(mainMenuOptions);
                        break;
                    case MainMenuOptionsEnum.User:
                        _navigator.CurrentViewModel = _mainNavVewModelFactory.CreateViewModel(mainMenuOptions);
                        break;
                    case MainMenuOptionsEnum.Settings:
                        _navigator.CurrentViewModel = _mainNavVewModelFactory.CreateViewModel(mainMenuOptions);
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
