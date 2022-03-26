using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories;
using BudgetApp_WPF.Core.State.Navigators;
using BudgetApp_WPF.MVVM.ViewModels;
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




        INavigator _mainViewModel;
        UsersViewsFactory _usersViewsFactory;




        ///





        public HomeMainMenuOptionCommand()
        {
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
                        break;
                    case MainMenuOptionsEnum.Goal:
                        break;
                    case MainMenuOptionsEnum.History:
                        break;
                    case MainMenuOptionsEnum.Income:
                        break;
                    case MainMenuOptionsEnum.Expense:
                        break;
                    case MainMenuOptionsEnum.Category:
                        break;
                    case MainMenuOptionsEnum.User:
                        break;
                    case MainMenuOptionsEnum.Settings:
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
