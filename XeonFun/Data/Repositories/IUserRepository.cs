using XeonFun.Entites.Models;

namespace XeonFun.Data
{
    public interface IUserRepository
    {
        Task<User> GetUser(string login, string password);
    }
}
