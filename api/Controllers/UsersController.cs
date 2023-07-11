using api.Data;
using api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // GET /api/users
    public class UsersController : ControllerBase
    {
        public readonly DataContext context;
        public UsersController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
            var users = await context.Users.ToListAsync();

            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id){
            return await context.Users.FindAsync(id);
        }

    }
}