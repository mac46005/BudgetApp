using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess.Interfaces
{
    public interface IGetAllAsync<T,U> where T : BaseModel<U>
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
