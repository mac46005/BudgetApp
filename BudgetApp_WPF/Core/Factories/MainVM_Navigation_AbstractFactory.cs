using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using BudgetApp_WPF.MVVM.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories
{
    internal class MainVM_Navigation_AbstractFactory : IAbstractViewModelFactory<MainMenuOptionsEnum>
    {
        IViewModelFactory _currentMonthVMFactory;
        IViewModelFactory _userDashboardVMF;






        public MainVM_Navigation_AbstractFactory
            (
            IViewModelFactory currentMonthVMFactory,
            IViewModelFactory userDashBoardVMF
            )
        {
            _currentMonthVMFactory = currentMonthVMFactory;
            _userDashboardVMF = userDashBoardVMF;
        }







        public IViewModel CreateViewModel(MainMenuOptionsEnum viewType)
        {
            var viewModel = _userDashboardVMF.CreateViewModel();
            switch (viewType)
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
                    viewModel = _userDashboardVMF.CreateViewModel();
                    break;
                case MainMenuOptionsEnum.Settings:
                    break;
                default:
                    break;
            }

            return viewModel;
        }
    }
}
