using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Factories.BaseFactories;
using BudgetApp_WPF.MVVM.ViewModels.ExpenseVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.ExpenseViewsFactory
{
    internal class ExpenseDBVMFactory : IViewModelFactory<ExpenseItem>
    {
        public ExpenseDBVMFactory()
        {

        }
        public object CreateViewModel()
        {
            return new ExpenseDashBoardViewModel();
        }
    }
}
