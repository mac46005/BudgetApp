using Budget_ClassLib.Models;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using BudgetApp_WPF.MVVM.ViewModels.UserVM;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories
{




    internal class UserDashBoardViewModelFactory : IViewModelFactory
    {
        IAPIEndpoint<User,int> _usersDataEndPoint;
        public UserDashBoardViewModelFactory(IAPIEndpoint<User,int> usersDataEndPoint)
        {
            _usersDataEndPoint = usersDataEndPoint;
        }



        public IViewModel CreateViewModel()
        {
            return new UserDashBoardViewModel(_usersDataEndPoint);
        }
    }
}
