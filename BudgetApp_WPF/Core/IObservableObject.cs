using System.ComponentModel;

namespace BudgetApp_WPF.Core
{
    /// <summary>
    /// An observable object that can be used to update the UI.
    /// Implements the INotifyPropertyChanged.
    /// </summary>
    internal interface IObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// Updates the property using INotifyPropertyChanged
        /// </summary>
        /// <param name="propName">The name of the property that is being updated</param>
        void OnPropertyChanged(string propName);
    }
}