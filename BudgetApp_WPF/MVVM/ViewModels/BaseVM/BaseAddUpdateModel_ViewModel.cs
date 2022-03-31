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
        public IAPIEndpoint<T, U> APIEndPoint { get; }

        public ICommand ManipulateDataCommand { get; }

        public DataManipulationOptions Option { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public BaseAddUpdateModel_ViewModel(IAPIEndpoint<T,U> apiEndPoint,T model)
        {
            APIEndPoint = apiEndPoint;
            Model = model;
        }
        public BaseAddUpdateModel_ViewModel(IAPIEndpoint<T,U> apiEndPoint)
        {
            APIEndPoint - apiEndPoint;
        }
    }
}
