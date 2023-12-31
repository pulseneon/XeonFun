﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using XeonFun.Entites.Requests;
using XeonFun.Services.Service;

namespace XeonFun.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration _configuration;
        private UserService _userService;

        public AuthController(IConfiguration configuration, UserService userService)
        {
            _configuration = configuration;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<AuthResponse> AuthAsync([FromBody] AuthRequest auth)
        {
            AuthResponse response = new();

            if (auth is not null)
            {
                response = await _userService.Authentcate(auth);
            }

            return response;
        }

        //[Authorize]
        //[HttpGet]
        //public async void CheckValideToken()
        //{
        //    ClaimsPrincipal currentUser = this.User;
        //    var id = currentUser.FindFirst("Id");
        //    //var login = context.User.FindFirst(ClaimTypes.Name);
        //    Console.WriteLine($"dfgdsgsdfg {id}");
        //}
    }
}
