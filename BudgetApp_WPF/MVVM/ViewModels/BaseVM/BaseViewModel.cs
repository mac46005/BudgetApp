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
    internal abstract class BaseViewModel<T> : IViewModel<T>
    {


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






        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
