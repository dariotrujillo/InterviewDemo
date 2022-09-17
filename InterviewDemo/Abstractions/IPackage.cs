using InterviewDemo.Model;

namespace InterviewDemo.Abstractions
{
    public interface IPackage
    {
        string Name { get; set; }
        string Description { get; set; }
        int? WarehouseId { get; set; }
        Warehouse Warehouse { get; set; }
    }
}
