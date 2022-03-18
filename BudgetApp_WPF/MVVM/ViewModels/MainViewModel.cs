using BudgetApp_WPF.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels
{
    internal class MainViewModel : ObservableObject
    {



        private object _currentViewMode = new CurrentMonthViewModel();
        public object CurrentViewModel 
        {
            get { return _currentViewMode; }
            set 
            {
                _currentViewMode = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }

        public MainViewModel()
        {

        }
    }
}
