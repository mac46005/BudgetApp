using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Factories.BaseFactories.Interfaces;
using BudgetApp_WPF.MVVM.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.UserViewsFactory
{
    internal class UsersDeleteViewModelFactory : IAbstractDeleteViewModelFactory<User, int>
    {
        private User _model;
        public object CreateViewModel(User viewType)
        {
            throw new NotImplementedException();
        }

        public object CreateViewModel()
        {
            return new UserDeleteViewModel(_model);
        }

        public void SetModel(User model)
        {
            _model = model;
        }
    }
}
