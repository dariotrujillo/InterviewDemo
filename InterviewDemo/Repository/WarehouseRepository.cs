using InterviewDemo.Model;
using InterviewDemo.DTO;
using Microsoft.EntityFrameworkCore;
using InterviewDemo.Abstractions;

namespace InterviewDemo.Repository
{
    public class WarehouseRepository : BaseGenericRepository<Warehouse, WarehouseDTO>, IWarehouseRepository
    {
        public WarehouseRepository(DataEFContext context) : base(context) { }
    }
}
