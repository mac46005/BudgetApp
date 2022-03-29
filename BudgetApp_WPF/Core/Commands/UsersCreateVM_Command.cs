using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories.BaseFactories;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces;
using BudgetApp_WPF.MVVM.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.Core.Commands
{
    internal class UsersCreateVM_Command : ICommand
    {
        private readonly IAbstractViewModelFactory<UserDataViewOptions> _userVM_AbstractFactory;
        private readonly INavigator<User> _userNavigatorViewModel;
        public UsersCreateVM_Command(INavigator<User> userNavigatorViewModel, IAbstractViewModelFactory<UserDataViewOptions> userVM_AbstractFactory)
        {
            _userNavigatorViewModel = userNavigatorViewModel;
            _userVM_AbstractFactory = userVM_AbstractFactory;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if(parameter is UserDataViewOptions)
            {
                UserDataViewOptions option = (UserDataViewOptions)parameter;
                _userNavigatorViewModel.ViewModel = _userVM_AbstractFactory.CreateViewModel(option);
            }
        }
    }
}
