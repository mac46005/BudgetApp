using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess
{
    internal interface IDeleteAsync<T,U>
    {
        Task DeleteAsync(U ID);
    }
}
