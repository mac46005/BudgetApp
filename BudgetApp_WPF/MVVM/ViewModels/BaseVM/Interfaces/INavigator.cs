using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces
{
    /// <summary>
    /// The INavigator controls the selection of view models.
    /// The ICommand is used to determine the selection of view models.
    /// </summary>
    /// <typeparam name="T">A model class the represents this view model</typeparam>
    internal interface INavigator<T> : IViewModel<T>
    {
        object ViewModel { get; set; }
        ICommand UpdateCurrentViewModelICommand { get; }
        void OnCurrentViewModelResolved(object? sender, EventArgs? eventArgs);
    }
}
