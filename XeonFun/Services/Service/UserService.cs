using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using XeonFun.Data;
using XeonFun.Entites.Models;
using XeonFun.Entites.Requests;

namespace XeonFun.Services.Service
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public UserService(IUserRepository repository, IConfiguration configuration)
        {
            _userRepository = repository;
            _configuration = configuration;
        }

        public async Task<AuthResponse> Authentcate(AuthRequest model)
        {
            // var user = await _userRepository.GetUser(model.Login, model.Password);

            // test 
            User user = new();
            user.Id = 1;
            user.Username = "pulseenepn";

            // if (user == null)
            // {
            // todo: user is null
            // }

            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var claims = new List<Claim>
            {
                new Claim("Id", user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim("IsDeleted", user.IsDeleted.ToString())
            };

            var jwt = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddDays(5),
                notBefore: DateTime.UtcNow,
                signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
                );

            var token = new JwtSecurityTokenHandler().WriteToken(jwt);

            AuthResponse response = new(user, token);

            return response;
        }
    }
}
