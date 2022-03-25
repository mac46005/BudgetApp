using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BudgetDB_APIAccess_ClassLib.API.Interfaces
{
    public interface IGetAsync<T, U> where T : BaseModel<U> 
    {
        Task<T> GetAsync(U ID);
        Task<IEnumerable<T>> GetAsync();
    }
}
