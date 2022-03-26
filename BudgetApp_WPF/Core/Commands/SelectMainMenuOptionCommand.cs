using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories;
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
    internal class SelectMainMenuOptionCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;




        MainViewModel _mainViewModel;
        /// ViewModel FACTORIES?
        UsersViewsFactory _usersViewsFactory;




        ///





        public SelectMainMenuOptionCommand(MainViewModel mainViewModel,UsersViewsFactory usersViewsFactory)
        {
            _mainViewModel = mainViewModel;
            _usersViewsFactory = usersViewsFactory;

        }






        public bool CanExecute(object? parameter)
        {
            return true;
        }







        public void Execute(object? parameter)
        {
            MainMenuOptionsEnum mainMenuOptions = (MainMenuOptionsEnum)parameter;
            switch (mainMenuOptions)
            {
                case MainMenuOptionsEnum.Current:
                    CurrentViewModel = new CurrentMonthViewModel();
                    break;
                case MainMenuOptionsEnum.Goal:
                    throw new NotImplementedException("Implement a View for this option.");
                    break;
                case MainMenuOptionsEnum.History:
                    CurrentViewModel = new HistoryDashBoardViewModel();
                    break;
                case MainMenuOptionsEnum.Income:
                    CurrentViewModel = new IncomeDashBoardViewModel();
                    break;
                case MainMenuOptionsEnum.Expense:
                    CurrentViewModel = new ExpenseDashBoardViewModel();
                    break;
                case MainMenuOptionsEnum.Category:
                    CurrentViewModel = new CategoryDashBoardViewModel();
                    break;
                case MainMenuOptionsEnum.User:
                    CurrentViewModel = _usersViewsFactory.CreateUserDashBoardViewModel();
                    break;
                case MainMenuOptionsEnum.Settings:

                    break;
                default:
                    break;
            }

        }
    }
}
