using AutoMapper;
using InterviewDemo.DTO;
using InterviewDemo.Model;

namespace InterviewDemo.Automapper
{
    public class AutomapperProfiles: Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Address, AddressDTO>().ReverseMap();
            CreateMap<Warehouse, WarehouseDTO>().ReverseMap();
            CreateMap<Package, PackageDTO>().ReverseMap();
        }
    }
}
