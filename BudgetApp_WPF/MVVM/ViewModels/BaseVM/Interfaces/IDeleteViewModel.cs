using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces
{
    interface IDeleteViewModel<T,U> : IDataManipulationViewModel<T,U> where T : BaseModel<U>
    {

    }
}
