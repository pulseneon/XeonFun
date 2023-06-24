using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using XeonFun.Data.Repositories.Interface;
using XeonFun.Entites.Models;
using XeonFun.Entites.Requests;
using XeonFun.Services.Interface;

namespace XeonFun.Services.Service
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IConfiguration configuration, IMapper mapper)
        {
            _userRepository = repository;
            _configuration = configuration;
            _mapper = mapper;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _userRepository.GetById(id);

            return user;
        }

        public async Task<User> AddUser(RegisterRequest model)
        {
            var user = _mapper.Map<RegisterRequest, User>(model);

            return await _userRepository.AddUser(user);
        }

        public async Task<AuthResponse> Authentcate(AuthRequest model)
        {
            var user = await _userRepository.GetByLogin(model.Login);

            if (user is null)
            {
                // todo: logging 
                return null;
            }

            var verifyPassword = Utilities.PasswordHasher.VerifyPassword(model.Password, user.Password);

            if (!verifyPassword)
            {
                // todo: logging 
                return null;
            }

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
