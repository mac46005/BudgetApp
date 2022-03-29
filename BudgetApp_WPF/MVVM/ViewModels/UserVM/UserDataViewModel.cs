using Budget_ClassLib.Models;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.UserVM
{
    internal class UserDataViewModel : BaseDataViewModel<User,int>
    {
        public UserDataViewModel(IAPIEndpoint<User,int> usersEndPoint) : base(usersEndPoint)
        {
             
        }
    }
}
