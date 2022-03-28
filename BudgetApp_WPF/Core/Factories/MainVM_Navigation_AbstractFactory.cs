using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using BudgetApp_WPF.MVVM.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories
{
    internal class MainVM_Navigation_AbstractFactory : IAbstractViewModelFactory<MainMenuOptionsEnum>
    {
        IViewModelFactory<ObservableCollection<ObservableCollection<object>>> _currentMonthVMFactory;
        IViewModelFactory<User> _userDashboardVMF;
        IViewModelFactory<IncomeItem> _incomeDBVMF;
        IViewModelFactory<ExpenseItem> _expenseDBVMF;





        public MainVM_Navigation_AbstractFactory
            (
            IViewModelFactory<ObservableCollection<ObservableCollection<object>>> currentMonthVMFactory,
            IViewModelFactory<User> userDashBoardVMF,
            IViewModelFactory<IncomeItem> incomeDBVMF,
            IViewModelFactory<ExpenseItem> expenseDBVMF
            )
        {
            _currentMonthVMFactory = currentMonthVMFactory;
            _userDashboardVMF = userDashBoardVMF;
            _incomeDBVMF = incomeDBVMF;
            _expenseDBVMF = expenseDBVMF;
        }

        public object CreateViewModel(MainMenuOptionsEnum viewType)
        {
            switch (viewType)
            {
                case MainMenuOptionsEnum.Current:
                    return _currentMonthVMFactory.CreateViewModel();
                case MainMenuOptionsEnum.Goal:
                    return _currentMonthVMFactory.CreateViewModel();
                case MainMenuOptionsEnum.History:
                    return _currentMonthVMFactory.CreateViewModel();
                case MainMenuOptionsEnum.Income:
                    return _incomeDBVMF.CreateViewModel();
                case MainMenuOptionsEnum.Expense:
                    return _expenseDBVMF.CreateViewModel();
                case MainMenuOptionsEnum.Category:
                    return _currentMonthVMFactory.CreateViewModel();
                case MainMenuOptionsEnum.User:
                    return _userDashboardVMF.CreateViewModel();
                case MainMenuOptionsEnum.Settings:
                    return _currentMonthVMFactory.CreateViewModel();
                default:
                    return _currentMonthVMFactory.CreateViewModel();
            }
        }
    }
}
