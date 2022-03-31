using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Commands.Base.Interfaces;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.MVVM.Models;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Commands.Base
{
    class BaseDataManipulationCommand<T, U> : IManipulateDataCommand<T, U> where T : BaseModel<U>
    {
        public T Model { get; set; }

        public IAPIEndpoint<T, U> APIEndPoint { get; }

        public DataManipulationOptions Option { get; set; }

        public DataManipulationItem<T, U> DataManipulationItem { get; set; }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            switch (Option)
            {
                case DataManipulationOptions.Read:
                    break;
                case DataManipulationOptions.Create:
                    APIEndPoint.POSTAsync(Model);
                    break;
                case DataManipulationOptions.Update:
                    APIEndPoint.POSTAsync(Model);
                    break;
                case DataManipulationOptions.Delete:
                    APIEndPoint.DELETEAsync(Model.ID);
                    break;
                default:
                    break;
            }
        }
    }
}
