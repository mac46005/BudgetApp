using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess
{
    internal interface IDataAccessAsync<T,U> : IGetAsync<T,U>, IGetAllAsync<T>, IUpdateAsync<T,U>, IDeleteAsync<T,U>
    {
    }
}
