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
    internal class SqlDataAccessByStoredProcedureAsync 
    {
        IConfiguration _configuration;
        public SqlDataAccessByStoredProcedureAsync(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private string GetConnectionString(string connectionName)
        {
            return _configuration.GetConnectionString(connectionName);
        }


        public async Task<T> LoadSingleDataAsync<T,U>(string connectionName, string storedProcedure,U parameter)
        {
            using (IDbConnection conn = new SqlConnection(GetConnectionString(connectionName)))
            {
                var result = await conn.QueryAsync<T>(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
                return result.FirstOrDefault();
            }
        }
        public async Task<IEnumerable<T>> LoadMultiDataAsync<T>(string connectionName, string storedProcedure)
        {
            using(IDbConnection conn = new SqlConnection(GetConnectionString(connectionName)))
            {
                return await conn.QueryAsync<T>(storedProcedure, commandType: CommandType.StoredProcedure);
            }
        }
        public async Task ModifyDataAsync<T,U>(string connectionName, string storedProcedure, U parameter)
        {
            using(IDbConnection conn = new SqlConnection(GetConnectionString(connectionName)))
            {
                await conn.QueryAsync<T>(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
