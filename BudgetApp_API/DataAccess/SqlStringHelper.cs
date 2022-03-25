using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess
{
    internal class SqlStringHelper
    {
        private string _tableName;

        public string ConnectionName { get; private set; }

        public SqlStringHelper(string tableName, string connectionName)
        {
            _tableName = tableName;
            ConnectionName = connectionName;
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
