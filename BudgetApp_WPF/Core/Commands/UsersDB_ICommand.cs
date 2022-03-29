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
    internal class UsersDB_ICommand : ICommand
    {
        public UsersDB_ICommand(INavigator<User> userDashBoardViewModel, IAbstractViewModelFactory<User> usersAddEdit_AbstractFactory)
        {
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            if(parameter is DataManipulationOptionsEnum)
            {
                DataManipulationOptionsEnum option = (DataManipulationOptionsEnum)parameter;
            }
        }
    }
}
