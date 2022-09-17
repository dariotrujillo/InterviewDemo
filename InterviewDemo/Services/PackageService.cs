using InterviewDemo.Abstractions;
using InterviewDemo.DTO;
using InterviewDemo.Repository;
using Microsoft.EntityFrameworkCore;

namespace InterviewDemo.Services
{
    public class PackageService: BaseGenericService<PackageDTO>, IPackageService<PackageDTO>
    {
        public PackageService(DataEFContext context) : base(new PackageRepository(context)) { }
    }
}
