using InterviewDemo.DTO;
using InterviewDemo.Model;

namespace InterviewDemo.Abstractions
{
    public interface IWarehouseDTO
    {
        string Name { get; set; }
        int? LocationId { get; set; }
        AddressDTO? Location { get; set; }
        public ICollection<PackageDTO>? Packages { get; set; }
    }
}
