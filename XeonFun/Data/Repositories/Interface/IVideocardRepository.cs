using System.Threading.Tasks;
using XeonFun.Entites.Models.Products;
using XeonFun.Entites.Requests;

namespace XeonFun.Data.Repositories.Interface
{
    public interface IVideocardRepository
    {
        Task<Videocard> GetById(int id);
        Task<Videocard> AddModel(Videocard videocard);
    }
}
