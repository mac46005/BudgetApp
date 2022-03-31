using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    internal abstract class BaseAddUpdateModel_ViewModel<T, U> : BaseViewModel<T>, IAddUpdateModel_ViewModel<T, U> where T : BaseModel<U>
    {

        public string Status { get; set; }
        public IAPIEndpoint<T, U> APIEndPoint { get; }

        public ICommand ManipulateDataCommand { get; }

        public DataManipulationOptions Option { get; set; }
        public BaseAddUpdateModel_ViewModel(IAPIEndpoint<T,U> apiEndPoint,T model)
        {
            Status = "Update";
            APIEndPoint = apiEndPoint;
            Model = model;
        }
        public BaseAddUpdateModel_ViewModel(IAPIEndpoint<T,U> apiEndPoint)
        {
            Status = "Add New";
            APIEndPoint = apiEndPoint;
        }
    }
}
