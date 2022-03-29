using Budget_ClassLib.Models;
using BudgetApp_API.DataAccess.Interfaces;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    internal abstract class BaseDataViewModel<T,U> : IDataViewModel<T,U> where T : BaseModel<U>
    {
        private ObservableCollection<T> _dataCollection;
        public ObservableCollection<T> DataCollection 
        {
            get
            {
                return _dataCollection;
            }
            set
            {
                _dataCollection = value;
                OnPropertyChanged("DataCollection");
            }
        }

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

        public BudgetDB_APIAccess_ClassLib.API.Interfaces.IGetAsync<T, U> GetAsync { get; }

        public BaseDataViewModel(IAPIEndpoint<T,U> apiEndPoint)
        {
            GetAsync = apiEndPoint;
            LoadData();
        }


        public virtual async void LoadData()
        {
            DataCollection = new ObservableCollection<T>(await GetAsync.GetAsync());
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
