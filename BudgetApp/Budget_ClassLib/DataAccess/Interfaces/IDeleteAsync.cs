using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.DataAccess.Interfaces
{
    public interface IDeleteAsync<T,U> where T : IModel<U>
    {
        Task DeleteAsync(U id);
    }
}
