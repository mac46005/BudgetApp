﻿using BudgetApp_WPF.MVVM.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp_WPF.MVVM.ViewModels.Base.Navigators
{
    /// <summary>
    /// Used for navigation views.
    /// </summary>
    /// <typeparam name="T">T represents the MODEL that the BaseViewModel represents</typeparam>
    internal interface INavigator<T>
    {
        BaseViewModel<T> CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelICommand { get; }
    }
}