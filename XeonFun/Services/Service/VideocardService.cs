using AutoMapper;
using XeonFun.Data.Repositories.Interface;
using XeonFun.Entites.Models;
using XeonFun.Entites.Models.Products;
using XeonFun.Entites.Requests;
using XeonFun.Services.Interface;

namespace XeonFun.Services.Service
{
    public class VideocardService: IVideocardService
    {
        private readonly IVideocardRepository _videocardRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public VideocardService(IVideocardRepository repository, IConfiguration configuration, IMapper mapper)
        {
            _videocardRepository = repository;
            _configuration = configuration;
            _mapper = mapper;
        }

        public async Task<Videocard> GetVideocard(int id)
        {
            var videocard = await _videocardRepository.GetById(id);

            return videocard;
        }

        public async Task<Videocard> AddVideocard(VideocardRequest videocard)
        {
            var model = _mapper.Map<VideocardRequest, Videocard>(videocard);
            var result = await _videocardRepository.AddModel(model);

            return result;
        }
    }
}
