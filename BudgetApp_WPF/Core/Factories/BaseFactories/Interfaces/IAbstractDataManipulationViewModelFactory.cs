using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.BaseFactories.Interfaces
{
    public interface IAbstractDataManipulationViewModelFactory<T, U> where T : BaseModel<U>
    {
        object CreateViewModel(DataManipulationOptions option);
        void SetModel(T model);
    }
}
