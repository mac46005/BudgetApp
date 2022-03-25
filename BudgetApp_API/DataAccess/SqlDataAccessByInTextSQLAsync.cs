using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess
{
    internal class SqlDataAccessByInTextSQLAsync
    {
        IConfiguration _configuration;
        public SqlDataAccessByInTextSQLAsync(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private string GetConnectionString(string connectionName)
        {
            return _configuration.GetConnectionString(connectionName);
        }


        public async Task<T> LoadSingleDataAsync<T, U>(string connectionName, string sqlText, U parameter)
        {
            using (IDbConnection conn = new SqlConnection(GetConnectionString(connectionName)))
            {
                var result = await conn.QueryAsync<T>(sqlText, parameter, commandType: CommandType.Text);
                return result.FirstOrDefault();
            }
        }
        public async Task<IEnumerable<T>> LoadMultiDataAsync<T>(string connectionName, string sqlText)
        {
            using (IDbConnection conn = new SqlConnection(GetConnectionString(connectionName)))
            {
                return await conn.QueryAsync<T>(sqlText, commandType: CommandType.Text);
            }
        }
        public async Task ModifyDataAsync<T, U>(string connectionName, string sqlText, U parameter)
        {
            using (IDbConnection conn = new SqlConnection(GetConnectionString(connectionName)))
            {
                await conn.QueryAsync<T>(sqlText, parameter, commandType: CommandType.Text);
            }
        }
    }
}
