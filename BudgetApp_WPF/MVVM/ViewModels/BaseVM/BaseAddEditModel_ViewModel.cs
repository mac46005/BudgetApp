using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
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
    internal class BaseAddEditModel_ViewModel<T, U> : IAddEditModel_ViewModel<T, U> where T : BaseModel<U>
    {

        public DataManipulationOptionsEnum Option { get; set; }
        public T Model { get; set; }

        public IAPIEndpoint<T, U> APIEndPoint => throw new NotImplementedException();

        public ICommand ManipulateDataCommand => throw new NotImplementedException();

       

        public BaseAddEditModel_ViewModel(IAPIEndpoint<T,U> apiEndPoint, DataManipulationOptionsEnum option = DataManipulationOptionsEnum.Insert,T model = default)
        {

            Option = option;
        }



        

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
