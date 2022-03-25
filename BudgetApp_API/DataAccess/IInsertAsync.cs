using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess
{
    internal interface IInsertAsync<T> where T : 
    {
        Task InsertAsync(T obj);
    }
}
