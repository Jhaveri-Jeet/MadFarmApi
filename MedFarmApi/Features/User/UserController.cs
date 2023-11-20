using MedFarmApi.Features.Shared;
using MedFarmApi.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore;

namespace MadFarmApi.Features.User
{
    [Route("/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly DatabaseContext databaseContext;

        public UserController(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            await databaseContext.Users.AddAsync(user);
            await databaseContext.SaveChangesAsync();
            return Ok("User Added !");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var user = await databaseContext.Users.ToListAsync();
            if (user is null) return NotFound();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var user = await databaseContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user is null) return NotFound();
            return Ok(user);
        }

        [HttpGet("/CheckUser")]
        public async Task<IActionResult> CheckUser([FromBody] User checkUser)
        {
            var user = await databaseContext.Users.Where(user => user.Email == checkUser.Email && user.Password == checkUser.Password).ToListAsync();
            if (user is null) return NotFound();
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser([FromBody] User newUser, [FromRoute] int id)
        {
            var user = await databaseContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            if(user is null) return NotFound();

            user.Name = newUser.Name;
            user.Email = newUser.Email;
            user.Password = newUser.Password;
            user.Address = newUser.Address;
            await databaseContext.SaveChangesAsync();

            return Ok("User Updated !");
        }
    }
}
