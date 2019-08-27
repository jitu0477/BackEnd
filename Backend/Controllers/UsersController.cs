using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using System.Linq;

namespace Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private readonly IFetchUsers _fetchUsers;

        public UsersController(IFetchUsers fetchUsers)
        {
            _fetchUsers = fetchUsers;
        }

        [HttpGet("fetchusers")]
        public async Task<IActionResult> FetchUsers()
        {
            try
            {
                return Ok(await _fetchUsers.GetUsers());
            }
            catch(Exception ex)
            {
                // Log ex error
                throw;
            }
        }
    }
}