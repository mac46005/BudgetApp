using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.Models
{
    public class User : BaseModel<int>
    {
        public int ID { get; set; }
        public string FistName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
    }
}
