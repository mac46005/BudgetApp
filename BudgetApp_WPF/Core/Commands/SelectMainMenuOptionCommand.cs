using BudgetApp_WPF.Core.Enums;
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
        public SelectMainMenuOptionCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
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
                    _mainViewModel.CurrentViewModel = new CurrentMonthViewModel();
                    break;
                case MainMenuOptionsEnum.Goal:
                    
                    break;
                case MainMenuOptionsEnum.History:
                    _mainViewModel.CurrentViewModel = new HistoryDashBoardViewModel();
                    break;
                case MainMenuOptionsEnum.Income:
                    _mainViewModel.CurrentViewModel = new IncomeDashBoardViewModel();
                    break;
                case MainMenuOptionsEnum.Expense:
                    _mainViewModel.CurrentViewModel = new ExpenseDashBoardViewModel();
                    break;
                case MainMenuOptionsEnum.Category:
                    _mainViewModel.CurrentViewModel = new CategoryDashBoardViewModel();
                    break;
                case MainMenuOptionsEnum.User:
                    _mainViewModel.CurrentViewModel = new UserDashBoardViewModel();
                    break;
                case MainMenuOptionsEnum.Settings:
                    
                    break;
                default:
                    break;
            }

        }
    }
}
