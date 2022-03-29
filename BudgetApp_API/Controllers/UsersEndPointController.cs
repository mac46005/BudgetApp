using Budget_ClassLib.Models;
using BudgetApp_API.DataAccess.BudgetAppDataAccess;
using BudgetApp_API.DataAccess.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BudgetApp_API.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class UsersEndPointController : ControllerBase
    {
        ICRUDDataAccessAsync<User,int> _usersDataAccess;
        public UsersEndPointController(ICRUDDataAccessAsync<User,int> usersDataAccess)
        {
            _usersDataAccess = usersDataAccess;
        }



        // GET: api/<UsersController>
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _usersDataAccess.GetAllAsync();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await _usersDataAccess.GetAsync(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task Post(User value)
        {
            await _usersDataAccess.InsertAsync(value);
        }


        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, User value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _usersDataAccess.DeleteAsync(id);
        }
    }
}
