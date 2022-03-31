using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories.BaseFactories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.AbstractFactories
{
    internal class UsersADMVMFactory : IAbstractDataManipulationViewModelFactory<User,int>
    {
        private readonly User _model;
        
        IAbstractDataViewModelFactory<User> _usersDVMFactory;
        IAbstractAddUpdateViewModelFactory<User, int, DataManipulationOptions> _AU_UserVMFactory;
        public UsersADMVMFactory(IAbstractDataViewModelFactory<User> usersDVMFactory, IAbstractAddUpdateViewModelFactory<User,int, DataManipulationOptions> AU_UserVMFactory)
        {
            _usersDVMFactory = usersDVMFactory;
            _AU_UserVMFactory = AU_UserVMFactory;
        }

        public object CreateViewModel(DataManipulationOptions option)
        {
            switch (option)
            {
                case DataManipulationOptions.View:
                    return _usersDVMFactory.CreateViewModel();
                case DataManipulationOptions.Insert:
                    return _AU_UserVMFactory.CreateViewModel(option);
                case DataManipulationOptions.Update:
                    _AU_UserVMFactory.SetModel(_model);
                    return _AU_UserVMFactory.CreateViewModel(option);
                case DataManipulationOptions.Delete:
                    return _usersDVMFactory.CreateViewModel();
                default:
                    return _usersDVMFactory.CreateViewModel();
            }
        }

        public void SetModel(User model)
        {
            _model = model;
        }
    }
}
