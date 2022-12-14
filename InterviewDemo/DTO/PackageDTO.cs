using InterviewDemo.Abstractions;

namespace InterviewDemo.DTO
{
    public class PackageDTO: EntityBaseDTO, IPackageDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? WarehouseId { get; set; }
        public WarehouseDTO? Warehouse { get; set; }
    }
}
