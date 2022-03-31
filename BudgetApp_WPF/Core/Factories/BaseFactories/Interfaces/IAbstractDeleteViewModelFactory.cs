using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.BaseFactories.Interfaces
{
    internal interface IAbstractDeleteViewModelFactory<T,U> : IAbstractViewModelFactory<T> where T : BaseModel<U>
    {
        void SetModel(T model);
    }
}
