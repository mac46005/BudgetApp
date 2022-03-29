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
    internal class BaseDataViewModel<T,U> : IDataViewModel<T,U> where T : BaseModel<U>
    {
        public ObservableCollection<T> DataCollection { get; set; }

        public T Model { get; set; }

        public BudgetDB_APIAccess_ClassLib.API.Interfaces.IGetAsync<T, U> GetAsync { get; }

        public BaseDataViewModel(IAPIEndpoint<T,U> apiEndPoint)
        {
            GetAsync = apiEndPoint;
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
