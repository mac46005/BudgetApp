using BudgetApp_WPF.Core;
using BudgetApp_WPF.Core.Commands;
using BudgetApp_WPF.Core.Factories;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using BudgetApp_WPF.MVVM.ViewModels.NavigationVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels
{
    internal class MainViewModel : ObservableObject, IDashBoardViewModel<object>
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







        public ObservableCollection<object> DataCollection { get; set; }
        public INavigator<object> Navigator { get; set; }
        public object Model { get; set; }

        public MainViewModel(MainNavigationViewModel mainNavigationViewModel)
        {
            Navigator = mainNavigationViewModel;
        }

    }
}
