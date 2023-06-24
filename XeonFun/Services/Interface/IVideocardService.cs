using XeonFun.Entites.Models.Products;

namespace XeonFun.Services.Interface
{
    public interface IVideocardService
    {
        Task<Videocard> GetVideocard(int id); 
    }
}
