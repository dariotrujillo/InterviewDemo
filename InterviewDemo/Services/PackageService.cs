using AutoMapper;
using InterviewDemo.Abstractions;
using InterviewDemo.DTO;
using InterviewDemo.Repository;
using Microsoft.EntityFrameworkCore;

namespace InterviewDemo.Services
{
    public class PackageService: BaseGenericService<PackageDTO>, IPackageService<PackageDTO>
    {
        public PackageService(DataEFContext context, IMapper mapper) : base(new PackageRepository(context, mapper), mapper)
        {
            _repository = (IPackageRepository<PackageDTO>)_repository;
        }

        public async Task<ICollection<PackageDTO>> GetAllFromWarehouse(int id)
        {
            return await ((IPackageRepository<PackageDTO>)_repository).GetAllFromWarehouse(id);
        }
    }
}
