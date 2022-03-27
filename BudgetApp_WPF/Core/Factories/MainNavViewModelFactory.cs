using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories
{
    internal class MainNavViewModelFactory : IAbstractViewModelFactory<object, MainMenuOptionsEnum>
    {
        public BaseViewModel<object> CreateViewModel(MainMenuOptionsEnum viewType)
        {
            switch (viewType)
            {
                case MainMenuOptionsEnum.Current:
                    break;
                case MainMenuOptionsEnum.Goal:
                    break;
                case MainMenuOptionsEnum.History:
                    break;
                case MainMenuOptionsEnum.Income:
                    break;
                case MainMenuOptionsEnum.Expense:
                    break;
                case MainMenuOptionsEnum.Category:
                    break;
                case MainMenuOptionsEnum.User:
                    break;
                case MainMenuOptionsEnum.Settings:
                    break;
                default:
                    break;
            }
        }
    }
}
