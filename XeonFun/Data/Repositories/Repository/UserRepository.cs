using AutoMapper;
using Microsoft.EntityFrameworkCore;
using XeonFun.Data.Repositories.Interface;
using XeonFun.Entites.Models;

namespace XeonFun.Data.Repositories.Repository
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

        public async Task<User> GetUser(string login) => await _context.Users.FirstOrDefaultAsync(x => x.Username == login);

        public async Task<User> GetUser(int id) => await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<User> AddUser(User user)
        {
            await _context.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}
