using BudgetApp_WPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels
{
    internal class BashViewModel<T> : ObservableObject, IViewModel<T>
    {
        public T Model { get; set; }
    }
}
