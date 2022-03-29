using BudgetApp_WPF.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.Core.Commands
{
    internal class UsersDB_ICommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            if(parameter is DataManipulationOptionsEnum)
            {
                DataManipulationOptionsEnum option = (DataManipulationOptionsEnum)parameter;
            }
        }
    }
}
