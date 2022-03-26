using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Commands
{
    public class UserDataManipulationCommand
    {
        public event EventHandler? CanExecuteChanged;
        public UserDataManipulationCommand()
        {
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            // Add a switch statement depending the data manipulation enum given
        }
    }
}
