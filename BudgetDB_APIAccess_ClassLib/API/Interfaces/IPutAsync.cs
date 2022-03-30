using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDB_APIAccess_ClassLib.API.Interfaces
{
    /// <summary>
    /// An API PUT function that access the API through an API client object.
    /// </summary>
    /// <typeparam name="T">Must inheret from BaseModel</typeparam>
    /// <typeparam name="U">The data that represents the ID property of the BaseModel</typeparam>
    public interface IPutAsync<T,U>
    {
        Task PUTAsync(T obj, U ID);
    }
}
