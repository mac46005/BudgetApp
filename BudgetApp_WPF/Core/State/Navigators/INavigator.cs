using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.State.Navigators
{
    public enum NavigationOptions
    {
        Current,
        Goal,
        History,
        Income,
        Expense,
        Category,
        User,
        Settings
    }
    public interface INavigator
    {
    }
}
