using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Commands
{
    public class UserDataManipulationCommand
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
