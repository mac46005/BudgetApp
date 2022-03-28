using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories
{
    /// <summary>
    /// Creates a viewmodel-T-. T represents the model that represents the ViewModel
    /// </summary>
    /// <typeparam name="T">Represents the model for the ViewModel being created</typeparam>
    internal interface IViewModelFactory<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>A View Model</returns>
        IViewModel<T> CreateViewModel();
    }
}
