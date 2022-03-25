using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess.Interfaces
{
    public interface ICRUDDataAccessAsync<T, U> : IInsertAsync<T,U>,IGetAsync<T, U>, IGetAllAsync<T,U>, IUpdateAsync<T, U>, IDeleteAsync<T, U> where T : BaseModel<U>
    {
    }
}
