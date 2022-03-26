﻿using BudgetApp_WPF.Core;
using BudgetApp_WPF.Core.Commands;
using BudgetApp_WPF.Core.Factories;
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

        UsersViewsFactory _userViewsFactory;





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






        public MainViewModel(UsersViewsFactory usersViewsFactory)
        {
            _userViewsFactory = usersViewsFactory;
        }




        public ICommand SelectMainMenuOptionCommand => new SelectMainMenuOptionCommand(this, _userViewsFactory);
    }
}
