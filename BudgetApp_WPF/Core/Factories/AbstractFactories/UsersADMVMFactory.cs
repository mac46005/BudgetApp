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
        private User _model;
        
        IAbstractDataViewModelFactory<User> _usersDMVMFactory;
        IAbstractAddUpdateViewModelFactory<User, int, DataManipulationOptions> _AU_UserVMFactory;
        IAbstractDeleteViewModelFactory<User, int> _userDeleteVMFactory;
        public UsersADMVMFactory(IAbstractDataViewModelFactory<User> usersDMVMFactory, IAbstractAddUpdateViewModelFactory<User,int, DataManipulationOptions> AU_UserVMFactory,IAbstractDeleteViewModelFactory<User,int> userDeleteVMFactory)
        {
            _usersDMVMFactory = usersDMVMFactory;
            _AU_UserVMFactory = AU_UserVMFactory;
            _userDeleteVMFactory = userDeleteVMFactory;
        }

        public object CreateViewModel(DataManipulationOptions option)
        {
            switch (option)
            {
                case DataManipulationOptions.Read:
                    return _usersDMVMFactory.CreateViewModel();
                case DataManipulationOptions.Create:
                    return _AU_UserVMFactory.CreateViewModel(option);
                case DataManipulationOptions.Update:
                    _AU_UserVMFactory.SetModel(_model);
                    return _AU_UserVMFactory.CreateViewModel(option);
                case DataManipulationOptions.Delete:
                    return _userDeleteVMFactory.CreateViewModel();
                default:
                    return _usersDMVMFactory.CreateViewModel();
            }
        }

        public void SetModel(User model)
        {
            _model = model;
        }
    }
}
