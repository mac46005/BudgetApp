using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_WPF.Core.Factories.BaseFactories.Interfaces
{
    internal interface IAbstractAddUpdateViewModelFactory<T, U, D>: IAbstractViewModelFactory<D> where T : BaseModel<U>
    {
        void SetModel(T model);
    }

}
