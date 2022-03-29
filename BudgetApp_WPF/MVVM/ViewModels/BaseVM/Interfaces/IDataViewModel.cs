using Budget_ClassLib.Models;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces
{
    interface IDataViewModel<T,U> : IViewModel<T> where T : BaseModel<U>
    {
        IGetAsync<T,U> GetAsync { get; }
        ObservableCollection<T> DataCollection { get; set; }
        void LoadData();
    }
}
