using Budget_ClassLib.Models;
using BudgetApp_API.DataAccess.Interfaces;
using BudgetApp_WPF.Core.Commands.UserCommands;
using BudgetApp_WPF.Core.Factories.BaseFactories;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.UserVM
{
    internal class AddUpdateUserViewModel : BaseAddUpdateModel_ViewModel<User,int>
    {
        /// <summary>
        /// Used for updating user information
        /// </summary>
        /// <param name="usersDataEndPoint"></param>
        /// <param name="model"></param>
        public AddUpdateUserViewModel(IAPIEndpoint<User,int> usersDataEndPoint,User model) : base(usersDataEndPoint,model)
        {
            Status += " User";
            this.ManipulateDataCommand = new UserDataCommand(this.APIEndPoint,this.Option);
        }
        

        /// <summary>
        /// Used for creating a user
        /// </summary>
        /// <param name="usersDataEndPoint"></param>
        public AddUpdateUserViewModel(IAPIEndpoint<User,int> usersDataEndPoint) : base(usersDataEndPoint)
        {
            Status += " User";
        }
    }
}
