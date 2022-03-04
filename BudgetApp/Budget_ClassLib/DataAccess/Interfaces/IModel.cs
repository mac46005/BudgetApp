using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.DataAccess.Interfaces
{
    public class IModel<T>
    {
        T ID { get; set; }
    }
}
