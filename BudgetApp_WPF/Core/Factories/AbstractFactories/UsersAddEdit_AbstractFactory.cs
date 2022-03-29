﻿using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Factories.BaseFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.AbstractFactories
{
    internal class UsersAddEdit_AbstractFactory : IAbstractViewModelFactory<User>
    {
        public UsersAddEdit_AbstractFactory()
        {

        }

        public object CreateViewModel(User viewType)
        {
            throw new NotImplementedException();
        }
    }
}
