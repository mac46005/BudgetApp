using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels.CategoryVM
{
    internal class CategoryDashBoardViewModel : IDashBoardViewModel<IDashBoardViewModel<object>>
    {
        public ObservableCollection<IDashBoardViewModel<object>> DataCollection { get; set; }
        public object ViewModel { get; set; }

        public ICommand UpdateCurrentViewModelICommand { get; }

        public IDashBoardViewModel<object> Model { get; set; }

        public CategoryDashBoardViewModel()
        {

        }

        public void LoadData()
        {
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propName)
        {
            OnPropertyChanged(propName);
        }
    }
}
