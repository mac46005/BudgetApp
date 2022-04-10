using BudgetApp_WPF.Core;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    internal abstract class BaseViewModel<T> : ObservableObject, IViewModel<T>
    {


        private T _model = default;
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
    }
}
