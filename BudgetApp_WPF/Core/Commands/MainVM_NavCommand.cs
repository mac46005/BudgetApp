using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories;
using BudgetApp_WPF.MVVM.ViewModels;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.Core.Commands
{
    internal class MainVM_NavCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;




        private readonly INavigator<object> _navigator;
        private readonly IAbstractViewModelFactory<MainMenuOptionsEnum> _mainNavVewModelFactory;



        ///





        public MainVM_NavCommand(INavigator<object> navigator, IAbstractViewModelFactory<MainMenuOptionsEnum> mainNavViewModelFactory)
        {
            _navigator = navigator;
            _mainNavVewModelFactory = mainNavViewModelFactory;
        }






        public bool CanExecute(object? parameter)
        {
            return true;
        }







        public void Execute(object? parameter)
        {
            if (parameter is MainMenuOptionsEnum)
            {
                MainMenuOptionsEnum mainMenuOptions = (MainMenuOptionsEnum)parameter;
                _navigator.CurrentViewModel = _mainNavVewModelFactory.CreateViewModel(mainMenuOptions);
            }

        }
    }
}
