using Budget_ClassLib.Models;
using BudgetApp_API.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess.BudgetAppDataAccess
{
    internal class UsersDataAccess : BaseSqlDataAccess,ICRUDDataAccessAsync<User, int>
    {
        SqlStringHelper _sqlStringHelper = new SqlStringHelper("Users", "BudgetDB");


        public UsersDataAccess(
            SqlDataAccessByStoredProcedureAsync sqlDataAccessByStoredProcedureAsync, 
            SqlDataAccessByInTextSQLAsync sqlDataAccessByInTextSQLAsync
            ) 
            : base(sqlDataAccessByStoredProcedureAsync,sqlDataAccessByInTextSQLAsync)
        {

        }


        public async Task DeleteAsync(int ID)
        {
            await _sqlDataAccessByStoredProcedureAsync.ModifyDataAsync<User, dynamic>
                (
                _sqlStringHelper.ConnectionName,
                _sqlStringHelper.StoredProcedureName("DeleteUser"),
                new { ID = ID }
                );
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _sqlDataAccessByStoredProcedureAsync.LoadMultiDataAsync<User>
                (
                _sqlStringHelper.ConnectionName,
                _sqlStringHelper.StoredProcedureName("GetAllUsers")
                );
        }

        public async Task<User> GetAsync(int ID)
        {
            return await _sqlDataAccessByStoredProcedureAsync.LoadSingleDataAsync<User, dynamic>
                (
                _sqlStringHelper.ConnectionName,
                _sqlStringHelper.StoredProcedureName("GetUser"),
                new { ID = ID }
                );
        }

        public async Task UpdateAsync(User obj, int ID)
        {
            obj.ID = ID;
            await _sqlDataAccessByStoredProcedureAsync.ModifyDataAsync<User, User>
                (
                _sqlStringHelper.ConnectionName,
                _sqlStringHelper.StoredProcedureName("UpdateUser"),
                obj
                );
        }
    }
}
