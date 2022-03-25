using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess.Interfaces
{
    internal interface IInsertAsync<T>
    {
        Task InsertAsync(T obj);
    }
}
