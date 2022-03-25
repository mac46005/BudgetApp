using Budget_ClassLib.Models;
using BudgetApp_API.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp_API.DataAccess.BudgetAppDataAccess
{
    public class UsersDataAccess : ICRUDDataAccessAsync<User, int>
    {

        public UsersDataAccess()
        {

        }


        public Task DeleteAsync(int ID)
        {
            throw new NotImplementedException();
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
