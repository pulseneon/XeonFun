using XeonFun.Entites.Requests;

namespace XeonFun.Services.Interface
{
    public interface IUserService
    {
        Task<ResponseResult> Register();
        Task<AuthResponse> Authentcate();
    }
}
