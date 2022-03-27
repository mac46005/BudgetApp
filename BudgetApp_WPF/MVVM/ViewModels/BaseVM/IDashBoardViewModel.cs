using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    internal interface IDashBoardViewModel<T>
    {
        ObservableCollection<T> DataCollection { get; set; }
        INavigator<T> Navigator { get; set; }
    }
}
