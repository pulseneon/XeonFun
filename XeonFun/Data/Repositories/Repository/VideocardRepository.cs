using AutoMapper;
using Microsoft.EntityFrameworkCore;
using XeonFun.Data.Repositories.Interface;
using XeonFun.Entites.Models;
using XeonFun.Entites.Models.Products;
using XeonFun.Entites.Requests;

namespace XeonFun.Data.Repositories.Repository
{
    public class VideocardRepository: IVideocardRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public VideocardRepository(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Videocard> GetById(int id) => await _context.Videocards.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<Videocard> AddModel(Videocard model)
        {
            await _context.AddAsync(model);
            var result = await _context.SaveChangesAsync();

            return model;
        }
    }
}
