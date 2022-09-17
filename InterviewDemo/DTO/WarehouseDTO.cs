using InterviewDemo.Abstractions;

namespace InterviewDemo.DTO
{
    public class WarehouseDTO: EntityBaseDTO
    {
        public string Name { get; set; } = string.Empty;
        public int? LocationId { get; set; }
        public AddressDTO Location { get; set; } = new AddressDTO();
        public ICollection<PackageDTO> Packages { get; set; } = new List<PackageDTO>();
    }
}
