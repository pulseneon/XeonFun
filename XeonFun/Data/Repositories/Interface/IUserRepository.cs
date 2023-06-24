using XeonFun.Entites.Models;

namespace XeonFun.Data.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<User> GetByLogin(string login);
        Task<User> GetById(int id);
        Task<User> AddUser(User user);
    }
}
