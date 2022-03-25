﻿using Budget_ClassLib.Models;
using BudgetApp_WPF.MVVM.ViewModels.User;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories
{
    public class UserViewsFactories
    {
        IAPIEndpoint<User, int> _usersDataEndPoint;
        public UserViewsFactories(IAPIEndpoint<User,int> usersDataEndPoint)
        {
            _usersDataEndPoint = usersDataEndPoint;
        }



        internal UserDashBoardViewModel CreateUserDashBoardViewModel()
        {
            return new UserDashBoardViewModel(_usersDataEndPoint);
        }





    }
}
