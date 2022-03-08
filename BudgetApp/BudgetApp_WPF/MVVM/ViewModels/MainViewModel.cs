using BudgetApp_WPF.Core;
using BudgetApp_WPF.MVVM.ViewModels.Category;
using BudgetApp_WPF.MVVM.ViewModels.Expense;
using BudgetApp_WPF.MVVM.ViewModels.Income;
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



        public MainViewModel()
        {
        }
    }
}