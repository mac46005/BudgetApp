using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace BudgetApp_API.DataAccess
{
    internal class SqlDataAccess 
    {
        IConfiguration _configuration;
        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private string GetConnectionString(string connectionName)
        {
            return _configuration.GetConnectionString(connectionName);
        }


        public T LoadSingleData<T,U>(string connectionName, string storedProcedure,U parameter)
        {
            using (IDbConnection conn = new SqlConnection(GetConnectionString(connectionName)))
            {
                var result = conn.Query<T>(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
                return result.FirstOrDefault();
            }
        }
        public IEnumerable<T> LoadMultiData<T>(string connectionName, string storedProcedure)
        {
            using(IDbConnection conn = new SqlConnection(GetConnectionString(connectionName)))
            {
                return conn.Query<T>(storedProcedure, commandType: CommandType.StoredProcedure);
            }
        }
        public void ModifyData<T,U>(string connectionName, string storedProcedure, U parameter)
        {
            using(IDbConnection conn = new SqlConnection(GetConnectionString(connectionName)))
            {
                conn.Query<T>(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
