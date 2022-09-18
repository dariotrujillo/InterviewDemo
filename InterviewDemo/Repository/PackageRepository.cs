using AutoMapper;
using InterviewDemo.Abstractions;
using InterviewDemo.DTO;
using InterviewDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace InterviewDemo.Repository
{
    public class PackageRepository : BaseGenericRepository<Package, PackageDTO>, IPackageRepository<PackageDTO>
    {
        public PackageRepository(DataEFContext context, IMapper mapper) : base(context, mapper) { }

        public override async Task<ICollection<PackageDTO>> GetAll()
        {
            var entities = await _entities.Include(x => x.Warehouse).ToListAsync();
            return this._mapper.Map<ICollection<PackageDTO>>(entities);
        }
        public async Task<ICollection<PackageDTO>> GetAllFromWarehouse(int id)
        {
            var entities = await _entities.Include(x => x.Warehouse).Where(x=>x.WarehouseId == id).ToListAsync();
            return this._mapper.Map<ICollection<PackageDTO>>(entities);
        }
    }
}
