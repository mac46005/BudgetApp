using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using Budget_ClassLib.Models;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using BudgetApp_WPF.Core.Factories.BaseFactories;
using BudgetApp_WPF.Core.Commands;

namespace BudgetApp_WPF.MVVM.ViewModels.UserVM
{
    internal class UserDashBoardViewModel : BaseDashBoardViewModel<User>
    {

        IAPIEndpoint<User, int> _userDataEndPoint;
        public UserDashBoardViewModel(IAPIEndpoint<User, int> usersDataEndPoint, IAbstractViewModelFactory<User> _usersAddEdit_AbstractFactory)
        {
            _userDataEndPoint = usersDataEndPoint;
            UpdateCurrentViewModelICommand = new UsersDB_ICommand(this, _usersAddEdit_AbstractFactory);
            LoadData();
        }



        public async override void LoadData()
        {
            DataCollection = new ObservableCollection<User>(await _userDataEndPoint.GetAsync());
        }
    }
}
