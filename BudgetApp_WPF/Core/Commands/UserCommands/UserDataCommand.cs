using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Commands.Base.Interfaces;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.MVVM.Models;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Commands.UserCommands
{
    internal class UserDataCommand : IManipulateDataCommand<User, int>
    {
        public IAPIEndpoint<User, int> APIEndPoint { get; }

        public DataManipulationOptions Option { get; }
        public DataManipulationItem<User, int> DataManipulationItem { get; }

        public User Model { get; }

        public UserDataCommand(IAPIEndpoint<User,int> usersDataEndPoint, DataManipulationOptions option,User model)
        {
            APIEndPoint = usersDataEndPoint;
            Option = option;
            Model = model;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            switch (Option)
            {
                case DataManipulationOptions.Read:
                    break;
                case DataManipulationOptions.Create:
                    APIEndPoint.POSTAsync(Model);
                    break;
                case DataManipulationOptions.Update:
                    APIEndPoint.PUTAsync(Model, Model.ID);
                    break;
                case DataManipulationOptions.Delete:
                    APIEndPoint.DELETEAsync(Model.ID);
                    break;
                default:
                    break;
            }
        }
    }
}
