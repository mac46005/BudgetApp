using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories
{
    /// <summary>
    /// The main factory resposible for producing the viewModel classes
    /// </summary>
    /// <typeparam name="T">BaseViewModel-T-</typeparam>
    /// <typeparam name="U">The parameter that will decide on the view to produce</typeparam>
    internal interface IAbstractViewModelFactory<T,U>
    {
        BaseViewModel<T> CreateViewModel(U viewType);
    }
}
