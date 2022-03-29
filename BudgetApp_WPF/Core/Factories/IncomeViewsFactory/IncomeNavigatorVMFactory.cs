using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Factories.BaseFactories;
using BudgetApp_WPF.MVVM.ViewModels.IncomeVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.IncomeViewsFactory
{
    internal class IncomeNavigatorVMFactory : INavigatorViewModelFactory<IncomeItem>
    {

        public IncomeNavigatorVMFactory()
        {

        }
        public object CreateViewModel()
        {
            return new IncomeNavigatorViewModel();
        }
    }
}
