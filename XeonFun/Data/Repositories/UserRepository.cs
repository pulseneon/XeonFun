using AutoMapper;
using Microsoft.EntityFrameworkCore;
using XeonFun.Entites.Models;

namespace XeonFun.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public UserRepository(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<User> GetUser(string login, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == login && x.Password == password);

            return user;
        }
    }
}
