using Budget_ClassLib.Models;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.UserVM
{
    internal class UserDeleteViewModel : BaseDeleteViewModel<User>
    {
        public UserDeleteViewModel(User user) : base(user)
        {

        }



    }
}
