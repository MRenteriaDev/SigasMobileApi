using API.Data;
using API.Models;
using API.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class AccountApiController : BaseApiController
    {
        private readonly ObservacionesWebDbContext _context;
        public AccountApiController(ObservacionesWebDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<User>> GetUserAsync([FromBody] LoginDto loginDto)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Email == loginDto.Email);

            if (user == null) return Unauthorized();

            return Ok(user);
        }
    }
}