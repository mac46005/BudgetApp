using Budget_ClassLib.Models;
using BudgetApp_WPF.MVVM.ViewModels.Base;
using BudgetApp_WPF.MVVM.ViewModels.User;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories
{
    public class UserDashBoardViewModelFactory : IViewModelFactory<UserDashBoardViewModel, object>
    {
        public BaseViewModel<object> CreateViewModel()
        {
            throw new NotImplementedException();
        }
    }
}
