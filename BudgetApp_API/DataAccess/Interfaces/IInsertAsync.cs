using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess.Interfaces
{
    internal interface IInsertAsync<T,U> where T :BaseModel<U>
    {
        Task InsertAsync(T obj);
    }
}
