using BudgetApp_WPF.Core;
using BudgetApp_WPF.Core.Commands;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories.BaseFactories.Interfaces;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces;
using BudgetApp_WPF.MVVM.ViewModels.NavigationVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels
{
    internal class MainViewModel : INavigator<object>
    {




        public MainViewModel(IAbstractViewModelFactory<MainMenuOptionsEnum> mainNavViewModelFactory)
        {
            UpdateCurrentViewModelICommand = new MainVM_NavCommand(this, mainNavViewModelFactory);
        }




        private object _viewModel;
        public object ViewModel 
        {
            get 
            {
                return _viewModel;
            }
            set
            {
                _viewModel = value;
                OnPropertyChanged("ViewModel");
            }
        }




        public ICommand UpdateCurrentViewModelICommand { get; }
        public object Model { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public void OnViewModelResolved(object? sender, EventArgs? eventArgs)
        {
            throw new NotImplementedException();
        }
    }
}
