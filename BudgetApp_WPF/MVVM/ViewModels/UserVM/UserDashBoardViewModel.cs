using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using Budget_ClassLib.Models;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;

namespace BudgetApp_WPF.MVVM.ViewModels.UserVM
{
    internal class UserDashBoardViewModel : BaseDashBoardViewModel<User>
    {

        IAPIEndpoint<User, int> _userDataEndPoint;
        public UserDashBoardViewModel(IAPIEndpoint<User, int> usersDataEndPoint)
        {

        }







        public override void LoadData()
        {
            
        }
    }
}
