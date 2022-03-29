using Budget_ClassLib.Models;
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




    internal class UserDBVMFactory : IViewModelFactory<User>
    {
        IAPIEndpoint<User, int> _usersDataEndPoint;
        IAbstractViewModelFactory<User> _usersAddEdit_AbstractFactory;
        public UserDBVMFactory(IAPIEndpoint<User, int> usersDataEndPoint, IAbstractViewModelFactory<User> usersAddEdit_AbstractFactory)
        {
            _usersDataEndPoint = usersDataEndPoint;
            _usersAddEdit_AbstractFactory = usersAddEdit_AbstractFactory;
        }



        public object CreateViewModel()
        {
            return new UserDashBoardViewModel(_usersDataEndPoint, _usersAddEdit_AbstractFactory);
        }
    }
}
