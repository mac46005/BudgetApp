using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.Models
{
    /// <summary>
    /// Used for databases for identification
    /// </summary>
    /// <typeparam name="U">The data type that represents the ID property</typeparam>
    public abstract class BaseModel<U> : IModel<U>
    {
        public U ID { get; set; }
        public override string ToString()
        {
            return $"ID: {ID}";
        }
    }
}
