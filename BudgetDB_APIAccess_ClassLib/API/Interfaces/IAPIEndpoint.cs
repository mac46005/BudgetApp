using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDB_APIAccess_ClassLib.API.Interfaces
{
    public interface IAPIEndpoint<T,U> : IGetAsync<T,U>, IDeleteAsync<T,U>, IPostAsync<T,U> , IPutAsync<T,U> where T : BaseModel<U>
    {
    }
}
