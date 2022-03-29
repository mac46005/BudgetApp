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
        public UsersVM_AbstractFactory()
        {

        }

        public object CreateViewModel(UserDataViewOptions viewType)
        {
            throw new NotImplementedException();
        }
    }
}
