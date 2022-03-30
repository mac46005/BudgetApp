using BudgetApp_WPF.Core.Factories.BaseFactories.Interfaces;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces;
using BudgetApp_WPF.MVVM.ViewModels.CategoryVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.CategoryViewsFactory
{
    internal class CategoryNavigatorVMFactory : INavigatorViewModelFactory<INavigator<object>>
    {
        public CategoryNavigatorVMFactory()
        {

        }
        public object CreateViewModel()
        {
            return new CategoryNavigatorViewModel();
        }
    }
}
