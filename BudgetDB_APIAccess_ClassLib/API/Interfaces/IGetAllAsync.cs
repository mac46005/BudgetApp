﻿using Budget_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BudgetDB_APIAccess_ClassLib.API.Interfaces
{
    public interface IGetAllAsync<T, U> where T : BaseModel<U> 
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
