using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDB_APIAccess_ClassLib.API.Interfaces
{
    /// <summary>
    /// An API DELETE function that access the API through an API client object.
    /// </summary>
    /// <typeparam name="T">Must inheret from BaseModel</typeparam>
    /// <typeparam name="U">The data that represents the ID property of the BaseModel</typeparam>
    public interface IDeleteAsync<T,U> where T : BaseModel<U>
    {
        /// <summary>
        /// Deletes a single object in the database contacted througth the API client
        /// </summary>
        /// <param name="ID">Represents the data type of the ID property of the BaseModel</param>
        /// <returns></returns>
        Task DELETEAsync(U ID);
    }
}
