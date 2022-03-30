using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.MVVM.Models;
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
        private readonly IAbstractDataManipulationViewFactory<User> _usersADMVFactory;
        private readonly INavigator<User> _userNavigatorViewModel;
        public UsersCreateVM_Command(INavigator<User> userNavigatorViewModel, IAbstractDataManipulationViewFactory<User> usersADMVFactoy)
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
            if(parameter is DataManipulationItem)
            {
                // Do something
            }
            else if(parameter is DataManipulationOptions)
            {
                DataManipulationOptions option = (DataManipulationOptions)parameter;
                _userNavigatorViewModel.ViewModel = _usersADMVFactory.CreateViewModel(option);
            }
        }
    }
}
