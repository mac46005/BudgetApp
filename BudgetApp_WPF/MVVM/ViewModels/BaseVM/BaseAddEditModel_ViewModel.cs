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
    internal abstract class BaseAddEditModel_ViewModel<T, U> : BaseViewModel<T>, IAddEditModel_ViewModel<T, U> where T : BaseModel<U>
    {

        public DataManipulationOptions Option { get; set; }

        public IAPIEndpoint<T, U> APIEndPoint { get; }

        public ICommand ManipulateDataCommand { get; }



        public BaseAddEditModel_ViewModel(IAPIEndpoint<T, U> apiEndPoint, DataManipulationOptions option = DataManipulationOptions.Insert, T model = default)
        {

            Option = option;
            if(model != null)
            {
                Model = model;
            }




        }

    }
}
