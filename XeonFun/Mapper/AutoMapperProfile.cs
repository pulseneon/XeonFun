using AutoMapper;
using XeonFun.Entites.Models;
using XeonFun.Entites.Models.Products;
using XeonFun.Entites.Requests;

namespace XeonFun.Mapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterRequest, User>();
            CreateMap<VideocardRequest, Videocard>();
        }
    }
}
