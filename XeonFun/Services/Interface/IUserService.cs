using XeonFun.Entites.Requests;

namespace XeonFun.Services.Interface
{
    public interface IUserService
    {
        Task<Register> Authentcate();
        Task<AuthResponse> Authentcate();
    }
}
