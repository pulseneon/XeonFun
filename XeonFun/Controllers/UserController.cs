using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XeonFun.Entites.Models;
using XeonFun.Entites.Requests;
using XeonFun.Services.Service;

namespace XeonFun.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] RegisterRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            model.Password = Utilities.PasswordHasher.HashPassword(model.Password);
            var user = await _userService.AddUser(model);

            if (user is null)
            {
                return StatusCode(500, "Error with adding model to database");
            }

            return Ok();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userService.GetUser(id);

            if (user is null)
            {
                return BadRequest();
            }

            return Ok(user);
        }
    }
}
