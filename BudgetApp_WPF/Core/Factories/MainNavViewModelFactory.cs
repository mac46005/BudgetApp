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
    internal class MainNavViewModelFactory : IAbstractViewModelFactory<object, MainMenuOptionsEnum>
    {
        IViewModelFactory<UserDashBoardViewModel, User> _userDashboardVMF;






        public MainNavViewModelFactory
            (
            IViewModelFactory<UserDashBoardViewModel, User> userDashBoardVMF
            )
        {
            _userDashboardVMF = userDashBoardVMF;
        }







        public BaseViewModel<object> CreateViewModel(MainMenuOptionsEnum viewType)
        {
            BaseViewModel<object> viewModel = (BaseViewModel<object>)_userDashboardVMF.CreateViewModel();
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
                    viewModel = (BaseViewModel<object>)_userDashboardVMF.CreateViewModel();
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
