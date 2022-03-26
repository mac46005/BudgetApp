﻿using BudgetApp_WPF.Core;
using BudgetApp_WPF.Core.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels
{
    internal class MainViewModel : ObservableObject
    {

        SelectMainMenuOptionCommand _selectMainMenuOptionCommand;

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

        public MainViewModel(SelectMainMenuOptionCommand selectMainMenuOptionCommand)
        {
            _selectMainMenuOptionCommand = selectMainMenuOptionCommand;
            _selectMainMenuOptionCommand.CurrentViewModel = this.CurrentViewModel;
        }
        public ICommand SelectMainMenuOptionCommand => _selectMainMenuOptionCommand;
    }
}
