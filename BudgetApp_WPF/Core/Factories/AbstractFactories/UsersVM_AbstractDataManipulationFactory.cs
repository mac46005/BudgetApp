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
    internal class UsersVM_AbstractDataManipulationFactory : IAbstractDataManipulationViewFactory<User,int>
    {
        private readonly User _user;
        
        IDataViewModelFactory<User> _usersDVMFactory;
        public UsersVM_AbstractDataManipulationFactory(IDataViewModelFactory<User> usersDVMFactory)
        {
            _usersDVMFactory = usersDVMFactory;
        }

        public object CreateViewModel(DataManipulationOptions option)
        {
            switch (option)
            {
                case DataManipulationOptions.View:
                    return _usersDVMFactory.CreateViewModel();
                case DataManipulationOptions.Insert:
                    return _usersDVMFactory.CreateViewModel();
                case DataManipulationOptions.Add:
                    return _usersDVMFactory.CreateViewModel();
                case DataManipulationOptions.Edit:
                    return _usersDVMFactory.CreateViewModel();
                case DataManipulationOptions.Delete:
                    return _usersDVMFactory.CreateViewModel();
                case DataManipulationOptions.Update:
                    return _usersDVMFactory.CreateViewModel();
                default:
                    return _usersDVMFactory.CreateViewModel();
            }
        }

        public void SetModel(User model)
        {
            throw new NotImplementedException();
        }
    }
}
