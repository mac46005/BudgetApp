using BudgetApp_WPF.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    internal class BaseDashBoardViewModel<T> : IDashBoardViewModel<T>
    {
        public ObservableCollection<T> DataCollection { get; set; }
        public IViewModel<T> CurrentViewModel { get; set; }

        public ICommand UpdateCurrentViewModelICommand { get; set; }

        public T Model { get; set; }



        public virtual void LoadData()
        {
            // Load external data
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
