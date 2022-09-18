using InterviewDemo.Model;
using InterviewDemo.DTO;
using Microsoft.EntityFrameworkCore;
using InterviewDemo.Abstractions;
using AutoMapper;

namespace InterviewDemo.Repository
{
    public class WarehouseRepository : BaseGenericRepository<Warehouse, WarehouseDTO>, IWarehouseRepository
    {
        public WarehouseRepository(DataEFContext context, IMapper mapper) : base(context, mapper) { }

        public override async Task<ICollection<WarehouseDTO>> GetAll()
        {
            var entities = await _entities.Include(x => x.Location).ToListAsync();
            return this._mapper.Map<ICollection<WarehouseDTO>>(entities);
        }
    }
}
