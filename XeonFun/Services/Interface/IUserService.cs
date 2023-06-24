using XeonFun.Entites.Models;
using XeonFun.Entites.Requests;

namespace XeonFun.Services.Interface
{
    public interface IUserService
    {
        Task<User> GetUser(int id);
        Task<User> AddUser(RegisterRequest model);
        Task<AuthResponse> Authentcate(AuthRequest model);
    }
}
