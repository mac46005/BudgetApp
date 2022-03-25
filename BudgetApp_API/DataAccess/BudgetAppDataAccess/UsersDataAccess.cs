﻿using Budget_ClassLib.Models;
using BudgetApp_API.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess.BudgetAppDataAccess
{
    internal class UsersDataAccess : BaseSqlDataAccess,ICRUDDataAccessAsync<User, int>
    {

        public UsersDataAccess(
            SqlDataAccessByStoredProcedureAsync sqlDataAccessByStoredProcedureAsync, 
            SqlDataAccessByInTextSQLAsync sqlDataAccessByInTextSQLAsync
            ) 
            : base(sqlDataAccessByStoredProcedureAsync,sqlDataAccessByInTextSQLAsync)
        {

        }


        public async Task DeleteAsync(int ID)
        {
            await _sqlDataAccessByStoredProcedureAsync.ModifyDataAsync<User, dynamic>("","",new { ID = ID });
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(int ID)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User obj, int ID)
        {
            throw new NotImplementedException();
        }
    }
}
