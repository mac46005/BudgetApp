using BudgetApp_WPF.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    internal class BaseDashBoardViewModel<T> : IDashBoardViewModel<T>
    {
        public ObservableCollection<T> DataCollection { get; set; }
        public INavigator Navigator { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;



        /// <summary>
        /// Load data from external source
        /// </summary>
        public virtual void LoadData()
        {

        }

        public void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
