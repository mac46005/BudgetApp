﻿using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
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
    internal class AddUpdateUserVMFactory : IAbstractAddUpdateViewModelFactory<User,int,DataManipulationOptions>
    {
        private readonly T _model;

        IAPIEndpoint<User, int> _usersDataEndPoint;
        public AddUpdateUserVMFactory(IAPIEndpoint<User,int> usersDataEndPoint)
        {
            _usersDataEndPoint = usersDataEndPoint;
        }
        public object CreateViewModel(DataManipulationOptions option)
        {
            switch (option)
            {
                case DataManipulationOptions.Insert:
                    return new AddUpdateUserViewModel(_usersDataEndPoint);
                case DataManipulationOptions.Edit:
                    var vm = new AddUpdateUserViewModel(_usersDataEndPoint);
                    vm.Model = _model;
                    return vm;
                default:
                    throw new Exception("Option not selected");
            }
        }
        public object CreateViewModel()
        {
            throw new NotImplementedException();
        }

        public void SetModel(User model)
        {
            _model = model;
        }
    }
}
