using BudgetApp_WPF.Core;
using BudgetApp_WPF.MVVM.ViewModels.Category;
using BudgetApp_WPF.MVVM.ViewModels.Expense;
using BudgetApp_WPF.MVVM.ViewModels.History;
using BudgetApp_WPF.MVVM.ViewModels.Income;
using BudgetApp_WPF.MVVM.ViewModels.User;
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

        private CategoryDashBoardViewModel _categoryDashBoardViewModel;
        public CategoryDashBoardViewModel CategoryDashBoardViewModel
        {
            get { return _categoryDashBoardViewModel; }
            set
            {
                _categoryDashBoardViewModel = value;
                OnPropertyChanged("CategoryDashBoardViewModel");
            }
        }




        private CurrentMonthViewModel _currentMonethViewModel;
        public CurrentMonthViewModel CurrentMonthViewModel 
        {
            get { return _currentMonethViewModel; }
            set 
            {
                _currentMonethViewModel = value;
                OnPropertyChanged("CurrentMonthViewModel");
            } 
        }


        private HistoryDashBoardViewModel _historyDashBoardViewModel;
        public HistoryDashBoardViewModel HistoryDashBoardViewModel
        {
            get { return _historyDashBoardViewModel;}
            set
            {
                _historyDashBoardViewModel = value;
                OnPropertyChanged("HistoryDashBoardViewModel");
            }
        }


        private IncomeDashBoardViewModel _incomeDashBoardViewModel;
        public IncomeDashBoardViewModel IncomeDashBoardViewModel
        {
            get { return _incomeDashBoardViewModel; }
            set
            {
                _incomeDashBoardViewModel = value;
                OnPropertyChanged("IncomeDashBoardViewModel");
            }
        }


        private ExpenseDashBoardViewModel _expenseDashBoardViewModel;
        public ExpenseDashBoardViewModel ExpenseDashBoardViewModel
        {
            get { return _expenseDashBoardViewModel; }
            set
            {
                _expenseDashBoardViewModel = value;
                OnPropertyChanged("ExpenseDashBoardViewModel");
            }
        }

        UserDashBoardViewModel _userDashBoardViewModel;
        public UserDashBoardViewModel UserDashBoardViewModel
        {
            get { return _userDashBoardViewModel; }
            set
            {
                _userDashBoardViewModel = value;
                OnPropertyChanged("UserDashBoardViewModel");
            }
        }

        public MainViewModel()
        {
        }
    }
}