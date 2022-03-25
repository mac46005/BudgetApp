using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess
{
    internal abstract class BaseSqlDataAccess
    {
        SqlDataAccessByStoredProcedureAsync _sqlDataAccessByStoredProcedureAsync;
        SqlDataAccessByInTextSQLAsync _sqlDataAccessByInTextSqlAsync;
        public BaseSqlDataAccess(
            SqlDataAccessByStoredProcedureAsync sqlDataAccessByStoredProcedureAsync, 
            SqlDataAccessByInTextSQLAsync sqlDataAccessByInTextSqlAsync)
        {
            _sqlDataAccessByInTextSqlAsync = sqlDataAccessByInTextSqlAsync;
            _sqlDataAccessByStoredProcedureAsync = sqlDataAccessByStoredProcedureAsync;
        }
    }
}
