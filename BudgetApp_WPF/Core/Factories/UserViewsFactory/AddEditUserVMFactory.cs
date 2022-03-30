﻿using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Factories.BaseFactories.Interfaces;
using BudgetApp_WPF.MVVM.ViewModels.UserVM;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.UserViewsFactory
{
    internal class AddEditUserVMFactory : IViewModelFactory<User>
    {
        IAPIEndpoint<User, int> _usersDataEndPoint;
        public AddEditUserVMFactory(IAPIEndpoint<User,int> usersDataEndPoint)
        {
            _usersDataEndPoint = usersDataEndPoint;
        }
        public object CreateViewModel()
        {
            return new AddEditUserViewModel(_usersDataEndPoint);
        }
    }
}
