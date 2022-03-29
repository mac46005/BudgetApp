using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories.BaseFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.AbstractFactories
{
    internal class UsersVM_AbstractFactory : IAbstractViewModelFactory<UserDataViewOptions>
    {
        IDataViewModelFactory<User> _usersDVMFactory;
        public UsersVM_AbstractFactory(IDataViewModelFactory<User> usersDVMFactory)
        {
            _usersDVMFactory = usersDVMFactory;
        }

        public object CreateViewModel(UserDataViewOptions viewType)
        {
            switch (viewType)
            {
                case UserDataViewOptions.ViewUsers:
                    return _usersDVMFactory.CreateViewModel();
                case UserDataViewOptions.AddUser:
                    return _usersDVMFactory.CreateViewModel();
                case UserDataViewOptions.EditUser:
                    return _usersDVMFactory.CreateViewModel();
                case UserDataViewOptions.UpdateUser:
                    return _usersDVMFactory.CreateViewModel();
                case UserDataViewOptions.DeleteUser:
                    return _usersDVMFactory.CreateViewModel();
                default:
                    return _usersDVMFactory.CreateViewModel();
            }
        }
    }
}
