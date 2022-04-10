using Budget_ClassLib.Models;
using BudgetApp_WPF.Core;
using BudgetApp_WPF.Core.Commands.Base.Interfaces;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.MVVM.ViewModels.BaseVM.Interfaces;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels.BaseVM
{
    internal abstract class BaseAddUpdateModel_ViewModel<T, U> : BaseViewModel<T>, IAddUpdateModel_ViewModel<T, U> where T : BaseModel<U>
    {

        public string Status { get; set; }
        public IAPIEndpoint<T, U> APIEndPoint { get; }

        public DataManipulationOptions Option { get; set; }

        public ICommand RelayCommand { get; set; }

        public event EventHandler ViewResolvedEvent;



        public BaseAddUpdateModel_ViewModel(IAPIEndpoint<T, U> apiEndPoint, T model)
        {
            Status = "Update";
            APIEndPoint = apiEndPoint;
            Model = model;
            RelayCommand = new RelayCommand(o =>
            {
                BasicOptions basicOptions = (BasicOptions)o;
                MessageBoxResult result;
                switch (o)
                {
                    case BasicOptions.Ok:
                        APIEndPoint.PUTAsync(Model, Model.ID);
                        ViewResolvedEvent?.Invoke(this,new EventArgs());
                        break;
                    case BasicOptions.Cancel:
                        result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButton.YesNo);
                        if (result == MessageBoxResult.Yes)
                        {
                            ViewResolvedEvent?.Invoke(this, new EventArgs());
                        }
                        break;
                    default:
                        break;
                }
                ViewResolvedEvent?.Invoke(this, new EventArgs());
            });
        }
        public BaseAddUpdateModel_ViewModel(IAPIEndpoint<T, U> apiEndPoint)
        {
            Status = "Add New";
            APIEndPoint = apiEndPoint;
            RelayCommand = new RelayCommand(o =>
            {
                BasicOptions basicOptions = (BasicOptions)o;
                MessageBoxResult result;
                switch (o)
                {
                    case BasicOptions.Ok:
                        APIEndPoint.POSTAsync(Model);
                        ViewResolvedEvent?.Invoke(this, new EventArgs());
                        break;
                    case BasicOptions.Cancel:
                        result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButton.YesNo);
                        if (result == MessageBoxResult.Yes)
                        {
                            ViewResolvedEvent?.Invoke(this,new EventArgs());
                        }
                        break;
                    default:
                        break;
                }
            });
        }


    }
}
