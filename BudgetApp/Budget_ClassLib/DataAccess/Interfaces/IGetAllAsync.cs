using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.DataAccess.Interfaces
{
    public interface IGetAllAsync<T,U> where T : IModel<U>
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
