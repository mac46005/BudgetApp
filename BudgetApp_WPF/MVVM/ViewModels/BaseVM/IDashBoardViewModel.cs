using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface IDashBoardViewModel<T> : INavigator<T>
    {
        ObservableCollection<T> DataCollection { get; set; }
        void LoadData();
    }
}
