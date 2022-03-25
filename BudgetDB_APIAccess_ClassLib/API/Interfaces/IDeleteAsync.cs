using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDB_APIAccess_ClassLib.API.Interfaces
{
    public interface IDeleteAsync<T,U> where T : BaseModel<U>
    {
        Task DeleteAsync(U ID);
    }
}
