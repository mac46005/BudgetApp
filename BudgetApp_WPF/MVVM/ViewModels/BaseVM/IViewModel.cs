using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    internal interface IViewModel<T>
    {
        T Model { get; set; }
    }
}
