﻿using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    interface IAddEditModel_ViewModel<T,U> : IViewModel<T> where T : BaseModel<U>
    {
        IAPIEndpoint<T,U> APIEndPoint { get; }
        ICommand ManipulateDataCommand { get; }
        DataManipulationOptionsEnum Option { get; set; }
    }
}
