using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Factories.BaseFactories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.UserViewsFactory
{
    internal class UsersDeleteViewModelFactory : IAbstractDeleteViewModelFactory<User, int>
    {
        private readonly T _model;
        public object CreateViewModel(User viewType)
        {
            throw new NotImplementedException();
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
