using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.DataAccess.Interfaces
{
    public interface IGetAsync<T,U> where T : IModel<U>
    {
        Task<T> GetAsync(U id);
    }
}
