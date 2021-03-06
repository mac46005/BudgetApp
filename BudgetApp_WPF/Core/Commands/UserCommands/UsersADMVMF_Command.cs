using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories.BaseFactories.Interfaces;
using BudgetApp_WPF.MVVM.Models;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces;
using BudgetApp_WPF.MVVM.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.Core.Commands.UserCommands
{
    internal class UsersADMVMF_Command : ICommand
    {
        private readonly IAbstractDataManipulationViewModelFactory<User, int> _usersADMVFactory;
        private readonly INavigator<User> _userNavigatorViewModel;
        public UsersADMVMF_Command(INavigator<User> userNavigatorViewModel, IAbstractDataManipulationViewModelFactory<User, int> usersADMVFactoy)
        {
            _userNavigatorViewModel = userNavigatorViewModel;
            _usersADMVFactory = usersADMVFactoy;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is DataManipulationItem<User, int>)
            {
                DataManipulationItem<User, int> dataManipulationItem = (DataManipulationItem<User, int>)parameter;
                _usersADMVFactory.SetModel(dataManipulationItem.Model);
                _usersADMVFactory.CreateViewModel(dataManipulationItem.Option);
            }
            else if (parameter is DataManipulationOptions)
            {
                DataManipulationOptions option = (DataManipulationOptions)parameter;
                switch (option)
                {
                    case DataManipulationOptions.Read:
                        _userNavigatorViewModel.ViewModel = _usersADMVFactory.CreateViewModel(option);
                        break;
                    case DataManipulationOptions.Create:
                        BaseAddUpdateModel_ViewModel<User,int> vm = (BaseAddUpdateModel_ViewModel<User,int>)_usersADMVFactory.CreateViewModel(option);
                        vm.ViewModelResolvedEvent += _userNavigatorViewModel.OnViewModelResolved;
                        _userNavigatorViewModel.ViewModel = vm;
                        break;
                    case DataManipulationOptions.Update:
                        break;
                    case DataManipulationOptions.Delete:
                        break;
                    default:
                        break;
                }


            }
        }
    }
}
