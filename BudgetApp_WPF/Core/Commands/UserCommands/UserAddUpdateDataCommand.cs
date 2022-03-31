using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Commands.Interfaces;
using BudgetApp_WPF.Core.Enums;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Commands.UserCommands
{
    internal class UserAddUpdateDataCommand : IAddUpdateDataCommand<User, int>
    {
        public IAPIEndpoint<User, int> APIEndPoint { get; }

        public DataManipulationOptions Option { get; }
        public UserAddUpdateDataCommand(IAPIEndpoint<User,int> usersDataEndPoint, DataManipulationOptions option)
        {

        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            switch (Option)
            {
                case DataManipulationOptions.Read:
                    break;
                case DataManipulationOptions.Create:
                    break;
                case DataManipulationOptions.Update:
                    break;
                case DataManipulationOptions.Delete:
                    break;
                default:
                    break;
            }
        }
    }
}
