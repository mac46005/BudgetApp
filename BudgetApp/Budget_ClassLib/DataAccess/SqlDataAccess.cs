﻿using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.DataAccess
{
    public class SqlDataAccess
    {
        IConfiguration _configuration;
        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private string GetConnectionString(string connectionName)
        {
            return _configuration.GetConnectionString("");
        }




        public async Task ModifyData<T,U>(string connectionName,string storedProcedure,T data,U parameter = default)
        {
            using (IDbConnection connection = new SqlConnection())
            {
                await connection.QueryAsync<T>(storedProcedure,parameter,commandType: CommandType.StoredProcedure);
            }
        }
    }
}
