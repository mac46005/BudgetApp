using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess.Interfaces
{
    internal interface IUpdateAsync<T, U>
    {
        Task UpdateAsync(T obj, U ID);
    }
}
