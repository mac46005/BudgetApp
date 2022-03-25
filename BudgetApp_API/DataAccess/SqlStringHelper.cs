using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess
{
    public class SqlStringHelper
    {
        private string _tableName;

        public SqlStringHelper(string tableName)
        {
            _tableName = tableName;
        }

        public string StoredProcedureName(string procedureName)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("sp");
            stringBuilder.Append(_tableName);
            stringBuilder.Append("_");
            stringBuilder.Append(procedureName);

            return stringBuilder.ToString();
        }


    }
}
