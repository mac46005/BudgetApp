using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.User
{
    internal class UserDashBoardViewModel
    {
        IAPIEndpoint<Budget_ClassLib.Models.User, int> _usersDataEndPoint;
        public UserDashBoardViewModel(IAPIEndpoint<Budget_ClassLib.Models.User,int> usersDataEndPoint)
        {
            _usersDataEndPoint = usersDataEndPoint;
        }






    }
}
