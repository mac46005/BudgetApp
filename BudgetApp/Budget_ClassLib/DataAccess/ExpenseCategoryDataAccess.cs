using Budget_ClassLib.DataAccess.Interfaces;
using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_ClassLib.DataAccess
{
    public class ExpenseCategoryDataAccess : IDataAccessAsync<Expense_Category, int>
    {
        ISqlDataAccess _sqlDataAccess;
        public ExpenseCategoryDataAccess(ISqlDataAccess sqlDataAccess)
        {
            _sqlDataAccess = sqlDataAccess;
        }
        public async Task DeleteAsync(Expense_Category entity)
        {
            await _sqlDataAccess.ModifyData<Expense_Category,Expense_Category>("","",entity);
        }

        public async Task<IEnumerable<Expense_Category>> GetAllAsync()
        {
            return await _sqlDataAccess.LoadData<Expense_Category, dynamic>("","", new {});
        }

        public async Task<Expense_Category> GetAsync(int id)
        {
            var entity = await _sqlDataAccess.LoadData<Expense_Category, dynamic>("", "", new { ID = id });
            return entity.FirstOrDefault();
        }

        public async Task<Expense_Category> UpdateAsync(int id, Expense_Category entity)
        {
            await _sqlDataAccess.ModifyData<Expense_Category, Expense_Category>("","", entity);

            return entity;
        }
    }
}
