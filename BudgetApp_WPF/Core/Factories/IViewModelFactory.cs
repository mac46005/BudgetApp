using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories
{
    /// <summary>
    /// Creates a single view model class
    /// </summary>
    /// <typeparam name="T">A class that inherets a BaseViewModel</typeparam>
    /// <typeparam name="U">Is the BaseViewModels model type</typeparam>
    internal interface IViewModelFactory<T,U> where T : BaseViewModel<U>
    {
        BaseViewModel<U> CreateViewModel();
    }
}
