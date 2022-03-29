using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories.BaseFactories;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using BudgetApp_WPF.MVVM.ViewModels.UserVM;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.UserViewsFactory
{




    internal class UsersNavigatorVMFactory : INavigatorViewModelFactory<User>
    {
        IAbstractViewModelFactory<UserDataViewOptions> _usersVM_AbstractFactory;
        public UsersNavigatorVMFactory(IAbstractViewModelFactory<UserDataViewOptions> usersVM_AbstractFactory)
        { 
            _usersVM_AbstractFactory = usersVM_AbstractFactory;
        }



        public object CreateViewModel()
        {
            return new UsersNavigatorViewModel(_usersVM_AbstractFactory);
        }
    }
}
