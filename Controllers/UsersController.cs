using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _Context;
        public UsersController(DataContext context)
        {
            _Context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _Context.Users.ToListasync();
        }
        [HttpGet("{id}")]
        public async async<ActionResult<AppUser>> GetUsers(int id)
        {
            return await _Context.Users.Findasync(id);
        }
    }
}