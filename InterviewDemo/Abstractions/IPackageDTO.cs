using InterviewDemo.DTO;
using InterviewDemo.Model;

namespace InterviewDemo.Abstractions
{
    public interface IPackageDTO
    {
        string Name { get; set; }
        string Description { get; set; }
        int? WarehouseId { get; set; }
        WarehouseDTO Warehouse { get; set; }
    }
}
