using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    /// <summary>
    /// Used for navigation views.
    /// </summary>
    internal interface INavigator : IViewModel
    {
        IViewModel CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelICommand { get; }
    }
}
