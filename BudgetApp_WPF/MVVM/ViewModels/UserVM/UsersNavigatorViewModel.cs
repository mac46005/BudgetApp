using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using Budget_ClassLib.Models;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using BudgetApp_WPF.Core.Commands;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories.BaseFactories.Interfaces;
using BudgetApp_WPF.Core.Commands.UserCommands;
using System;

namespace BudgetApp_WPF.MVVM.ViewModels.UserVM
{
    internal class UsersNavigatorViewModel : BaseNavigatorViewModel<User>
    {
        public UsersNavigatorViewModel(IAbstractDataManipulationViewModelFactory<User,int> usersADMVFactory)
        {
            UpdateCurrentViewModelICommand = new UsersADMVMF_Command(this, usersADMVFactory);
        }
        public override void OnCurrentViewModelResolved(object? sender, EventArgs? eventArgs)
        {
            UpdateCurrentViewModelICommand.Execute(DataManipulationOptions.Read);
        }
    }
}
