using BudgetApp_WPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">The model that represents the view model</typeparam>
    internal class BaseViewModel<T> : ObservableObject, IViewModel<T>
    {
        public T Model { get; set; }
    }
}
