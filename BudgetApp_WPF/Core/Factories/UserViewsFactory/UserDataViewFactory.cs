using Budget_ClassLib.Models;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.UserViewsFactory
{
    internal class UserDataViewFactory
    {
        IAPIEndpoint<User, int> _usersDataEndPoint;
        public UserDataViewFactory(IAPIEndpoint<User,int> usersDataEndPoint)
        {
            _usersDataEndPoint = usersDataEndPoint;
        }
    }
}
