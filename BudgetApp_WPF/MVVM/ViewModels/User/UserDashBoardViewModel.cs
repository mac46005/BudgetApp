using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace BudgetApp_WPF.MVVM.ViewModels.User
{
    internal class UserDashBoardViewModel
    {
        IAPIEndpoint<Budget_ClassLib.Models.User, int> _usersDataEndPoint;
        public UserDashBoardViewModel(IAPIEndpoint<Budget_ClassLib.Models.User,int> usersDataEndPoint)
        {
            _usersDataEndPoint = usersDataEndPoint;


            LoadUserFromAPI();



        }


        ObservableCollection<Budget_ClassLib.Models.User> UsersCollection { get; set; }

        private async void LoadUserFromAPI()
        {
            UsersCollection = new ObservableCollection<Budget_ClassLib.Models.User>(await _usersDataEndPoint.GetAsync());
        }

    }
}
