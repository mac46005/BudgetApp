using BudgetApp_WPF.Core.Factories.BaseFactories;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using BudgetApp_WPF.MVVM.ViewModels.CategoryVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.CategoryViewsFactory
{
    internal class CategoryDBVMFactory : IViewModelFactory<IDashBoardViewModel<object>>
    {
        public CategoryDBVMFactory()
        {

        }
        public object CreateViewModel()
        {
            return new CategoryDashBoardViewModel();
        }
    }
}
