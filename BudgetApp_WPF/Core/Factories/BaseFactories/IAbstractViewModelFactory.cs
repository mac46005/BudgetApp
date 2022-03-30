using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.BaseFactories
{
    /// <summary>
    /// The main factory resposible for producing the viewModel classes
    /// </summary>
    /// <typeparam name="T">Used for defining an action depending on what is passed</typeparam>
    internal interface IAbstractViewModelFactory<T>
    {

        object CreateViewModel(T viewType);
        object CreateViewModel();
    }
}
