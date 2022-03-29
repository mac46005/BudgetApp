using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.Models
{
    public class BaseModel<U> : IModel<U>
    {
        public U ID { get; set; }
        public override string ToString()
        {
            return $"ID: {ID}";
        }
    }
}
