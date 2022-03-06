using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.DataAccess.Interfaces
{
    public interface IDataAccessAsync<T,U> : IGetAsync<T,U>, IGetAllAsync<T,U>,IDeleteAsync<T,U>,IUpdateASync<T,U> where T : IModel<U>
    {

    }
}
