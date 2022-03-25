using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.Models
{
    public interface IModel<T>
    {
        T ID { get; set; }
    }
}
