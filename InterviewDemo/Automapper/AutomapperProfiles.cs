using AutoMapper;
using InterviewDemo.DTO;
using InterviewDemo.Model;

namespace InterviewDemo.Automapper
{
    public class AutomapperProfiles: Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Address, AddressDTO>();
            CreateMap<Warehouse, WarehouseDTO>();
            CreateMap<Package, PackageDTO>();
        }
    }
}
