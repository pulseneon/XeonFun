using XeonFun.Entites.Models;

namespace XeonFun.Data.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<User> GetUser(string login);
        Task<User> GetUser(int id);
        Task<User> AddUser(User user);
    }
}
