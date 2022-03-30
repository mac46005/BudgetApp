using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BudgetDB_APIAccess_ClassLib.API.Interfaces
{
    /// <summary>
    /// An API POST function that access the API through an API client object.
    /// </summary>
    /// <typeparam name="T">Must inheret from BaseModel</typeparam>
    /// <typeparam name="U">The data that represents the ID property of the BaseModel</typeparam>
    public interface IPostAsync<T, U> where T : BaseModel<U> 
    {
        /// <summary>
        /// POST a single object in the API client
        /// </summary>
        /// <param name="obj">A class that inherets the BaseModel</param>
        /// <returns></returns>
        Task PostAsync(T obj);
    }
}
