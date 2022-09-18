using InterviewDemo.Abstractions;

namespace InterviewDemo.Model
{
    public class Package: EntityBase, IPackage
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? WarehouseId { get; set; }
        public Warehouse? Warehouse { get; set; }
    }
}
