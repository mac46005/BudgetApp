using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BudgetDB_APIAccess_ClassLib.API.Interfaces
{
    /// <summary>
    /// An API GET function that access the API through an API client object.
    /// </summary>
    /// <typeparam name="T">Must inheret from BaseModel</typeparam>
    /// <typeparam name="U">The data that represents the ID property of the BaseModel</typeparam>
    public interface IGetAsync<T, U> where T : BaseModel<U> 
    {
        /// <summary>
        /// Gets a single data from the API by ID
        /// </summary>
        /// <param name="ID">Represents the data type of the ID property of the base model</param>
        /// <returns>Returns a class that inherets from BaseModel</returns>
        Task<T> GETAsync(U ID);

        /// <summary>
        /// Gets all the data from the API
        /// </summary>
        /// <returns>Returns a class that inherets from BaseModel</returns>
        Task<IEnumerable<T>> GETAsync();
    }
}
