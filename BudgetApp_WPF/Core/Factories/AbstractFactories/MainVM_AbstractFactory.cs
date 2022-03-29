using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories.BaseFactories;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces;
using BudgetApp_WPF.MVVM.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.AbstractFactories
{
    internal class MainVM_AbstractFactory : IAbstractViewModelFactory<MainMenuOptionsEnum>
    {
        IViewModelFactory<ObservableCollection<ObservableCollection<object>>> _currentMonthVMFactory;
        INavigatorViewModelFactory<User> _userDashboardVMF;
        INavigatorViewModelFactory<IncomeItem> _incomeDBVMF;
        INavigatorViewModelFactory<ExpenseItem> _expenseDBVMF;
        INavigatorViewModelFactory<INavigator<object>> _categoryDBVMF;




        public MainVM_AbstractFactory
            (
            IViewModelFactory<ObservableCollection<ObservableCollection<object>>> currentMonthVMFactory,
            INavigatorViewModelFactory<User> userDashBoardVMF,
            INavigatorViewModelFactory<IncomeItem> incomeDBVMF,
            INavigatorViewModelFactory<ExpenseItem> expenseDBVMF,
            INavigatorViewModelFactory<INavigator<object>> categoryDBVMF
            )
        {
            _currentMonthVMFactory = currentMonthVMFactory;
            _userDashboardVMF = userDashBoardVMF;
            _incomeDBVMF = incomeDBVMF;
            _expenseDBVMF = expenseDBVMF;
            _categoryDBVMF = categoryDBVMF;
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
                    return _categoryDBVMF.CreateViewModel();
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
