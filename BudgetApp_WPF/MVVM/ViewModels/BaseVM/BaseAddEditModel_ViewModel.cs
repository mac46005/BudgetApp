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
    internal abstract class BaseAddEditModel_ViewModel<T, U> : IAddEditModel_ViewModel<T, U> where T : BaseModel<U>
    {

        public DataManipulationOptionsEnum Option { get; set; }
        private T _model;
        public T Model 
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
                OnPropertyChanged("Model");
            }
        }

        public IAPIEndpoint<T, U> APIEndPoint { get; }

        public ICommand ManipulateDataCommand { get; }



        public BaseAddEditModel_ViewModel(IAPIEndpoint<T, U> apiEndPoint, DataManipulationOptionsEnum option = DataManipulationOptionsEnum.Insert, T model = default)
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
