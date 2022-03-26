using BudgetApp_WPF.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories
{
    internal interface IViewModelFactory<T,U> where T : BaseViewModel<U>
    {
        BaseViewModel<U> CreateViewModel();
    }
}
