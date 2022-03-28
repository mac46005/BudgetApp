using System.ComponentModel;

namespace BudgetApp_WPF.Core
{
    internal interface IObservableObject : INotifyPropertyChanged
    {
        void OnPropertyChanged(string propName);
    }
}