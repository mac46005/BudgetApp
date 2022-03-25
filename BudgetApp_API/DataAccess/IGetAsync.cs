using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess
{
    internal interface IGetAsync<T,U>
    {
        Task<T> GetAsync(U ID);
    }
}
