using InterviewDemo.Abstractions;
using InterviewDemo.DTO;
using InterviewDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace InterviewDemo.Repository
{
    public class PackageRepository : BaseGenericRepository<Package, PackageDTO>, IPackageRepository
    {
        public PackageRepository(DataEFContext context) : base(context) {}
    }
}
