using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDB_APIAccess_ClassLib.API.Interfaces
{
    public interface IPutAsync<T,U>
    {
        Task PutAsync(T obj, U ID);
    }
}
