using BudgetApp_WPF.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    internal class BaseDashBoardViewModel<T> : IDashBoardViewModel<T>
    {
        public ObservableCollection<T> DataCollection { get; set; }
        public INavigator<T> Navigator { get; set; }
        public T Model { get; set; }
    }
}
