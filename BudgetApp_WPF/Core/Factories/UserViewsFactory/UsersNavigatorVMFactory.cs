using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories.BaseFactories.Interfaces;
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
        IAbstractDataManipulationViewModelFactory<User,int> _usersADMVMFactory;
        public UsersNavigatorVMFactory(IAbstractDataManipulationViewModelFactory<User,int> usersADMVMFactory)
        {
            _usersADMVMFactory = usersADMVMFactory;
        }



        public object CreateViewModel()
        {
            return new UsersNavigatorViewModel(_usersADMVMFactory);
        }
    }
}
