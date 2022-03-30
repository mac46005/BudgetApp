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
    /// <summary>
    /// The ViewModel that has a collection of data.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    interface IDataViewModel<T,U> : IViewModel<T> where T : BaseModel<U>
    {
       
        IGetAsync<T,U> GetAsync { get; }

        /// <summary>
        /// The collection of data from the external source
        /// </summary>
        ObservableCollection<T> DataCollection { get; set; }

        /// <summary>
        /// Loads the data from an external source
        /// </summary>
        void LoadData();
    }
}
