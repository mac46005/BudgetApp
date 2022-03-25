using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess
{
    internal interface IGetAllAsync<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
