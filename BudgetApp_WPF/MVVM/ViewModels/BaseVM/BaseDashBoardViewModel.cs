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
        private ObservableCollection<T> _dataCollection;
        public ObservableCollection<T> DataCollection 
        {
            get
            {
                return _dataCollection;
            }
            set
            {
                _dataCollection = value;
                OnPropertyChanged("DataCollection");
            }
        }


        private object _currentViewModel;
        public object ViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }

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
