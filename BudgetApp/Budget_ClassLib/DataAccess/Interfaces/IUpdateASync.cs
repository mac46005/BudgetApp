using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.DataAccess.Interfaces
{
    public interface IUpdateASync<T,U> where T : IModel<U>
    {
        Task<T> UpdateAsync(U id, T entity);
    }
}
