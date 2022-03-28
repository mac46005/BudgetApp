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






        public MainVM_Navigation_AbstractFactory
            (
            IViewModelFactory<ObservableCollection<ObservableCollection<object>>> currentMonthVMFactory,
            IViewModelFactory<User> userDashBoardVMF
            )
        {
            _currentMonthVMFactory = currentMonthVMFactory;
            _userDashboardVMF = userDashBoardVMF;
        }







        public object CreateViewModel(MainMenuOptionsEnum viewType)
        {
            switch (viewType)
            {
                case MainMenuOptionsEnum.Current:
                    return _currentMonthVMFactory.CreateViewModel();
                case MainMenuOptionsEnum.Goal:
                    throw new NotImplementedException();
                case MainMenuOptionsEnum.History:
                    throw new NotImplementedException();
                case MainMenuOptionsEnum.Income:
                    throw new NotImplementedException();
                case MainMenuOptionsEnum.Expense:
                    throw new NotImplementedException();
                case MainMenuOptionsEnum.Category:
                    throw new NotImplementedException();
                case MainMenuOptionsEnum.User:
                    return _userDashboardVMF.CreateViewModel();
                    throw new NotImplementedException();
                case MainMenuOptionsEnum.Settings:
                    throw new NotImplementedException();
                default:
                    return _currentMonthVMFactory.CreateViewModel();

            }

        }
    }
}
