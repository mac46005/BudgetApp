using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess.Interfaces
{
    internal interface IGetAsync<T, U> where T : BaseModel<U>
    {
        Task<T> GetAsync(U ID);
    }
}
