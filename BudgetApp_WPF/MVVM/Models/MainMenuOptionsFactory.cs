using BudgetApp_WPF.MVVM.ViewModels;
using BudgetApp_WPF.MVVM.ViewModels.
using BudgetApp_WPF.MVVM.ViewModels.Category;
using BudgetApp_WPF.MVVM.ViewModels.Expense;
using BudgetApp_WPF.MVVM.ViewModels.History;
using BudgetApp_WPF.MVVM.ViewModels.Income;
using BudgetApp_WPF.MVVM.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.Models
{
    internal class MainMenuOptionsFactory
    {
        public CurrentMonthViewModel CreateCurrentMonthViewModel()
        {
            return new CurrentMonthViewModel();
        }
        public CategoryDashBoardViewModel CreateCategoryDashBoardViewModel()
        {
            return new CategoryDashBoardViewModel();
        }
        public HistoryDashBoardViewModel CreateHistoryDashBoardViewModel()
        {
            return new HistoryDashBoardViewModel();
        }
        public IncomeDashBoardViewModel CreateIncomeDashBoardViewModel()
        {
            return new IncomeDashBoardViewModel();
        }
        public ExpenseDashBoardViewModel CreateExpenseDashBoardViewModel()
        {
            return new ExpenseDashBoardViewModel();
        }
        public UserDashBoardViewModel CreateUserDashBoardViewModel()
        {
            return new UserDashBoardViewModel();
        }




    }
}
