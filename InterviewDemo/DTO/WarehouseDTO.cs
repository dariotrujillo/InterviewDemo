using InterviewDemo.Abstractions;

namespace InterviewDemo.DTO
{
    public class WarehouseDTO: EntityBaseDTO, IWarehouseDTO
    {
        public string? Name { get; set; } = string.Empty;
        public int? LocationId { get; set; }
        public AddressDTO? Location { get; set; }
        public ICollection<PackageDTO>? Packages { get; set; }
    }
}
