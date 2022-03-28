using Budget_ClassLib.Models;
using BudgetApp_WPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    /// <summary>
    /// Base View Model class. Also implements IObservableObject
    /// </summary>
    /// <typeparam name="T">The model class that represents this ViewModel</typeparam>
    internal interface IViewModel<T> : IObservableObject
    {
        T Model { get; set; }
    }
}
