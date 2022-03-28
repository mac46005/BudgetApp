using BudgetApp_WPF.MVVM.ViewModels;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories
{
    internal class CurrentMonthDBVMFactory : IViewModelFactory<ObservableCollection<ObservableCollection<object>>>
    {
        public CurrentMonthDBVMFactory()
        {

        }
        public object CreateViewModel()
        {
            return new CurrentMonthViewModel();
        }
    }
}
