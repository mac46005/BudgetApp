using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using Budget_ClassLib.Models;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using BudgetApp_WPF.Core.Factories.BaseFactories;
using BudgetApp_WPF.Core.Commands;
using BudgetApp_WPF.Core.Enums;

namespace BudgetApp_WPF.MVVM.ViewModels.UserVM
{
    internal class UsersNavigatorViewModel : BaseNavigatorViewModel<User>
    {
        public UsersNavigatorViewModel(IAbstractViewModelFactory<UserDataViewOptions> UsersVM_AbtractFactory)
        {
            UpdateCurrentViewModelICommand = new UsersCreateVM_Command(this, UsersVM_AbtractFactory);
            
        }
    }
}
