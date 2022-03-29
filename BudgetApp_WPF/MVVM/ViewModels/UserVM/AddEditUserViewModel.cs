using Budget_ClassLib.Models;
using BudgetApp_API.DataAccess.Interfaces;
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
    internal class AddEditUserViewModel : BaseViewModel<User>
    {
        public AddEditUserViewModel(IAbstractViewModelFactory<User> usersAddEdit_AbstractFactory)
        {
            
        }
    }
}
