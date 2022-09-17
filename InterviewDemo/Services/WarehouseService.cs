using InterviewDemo.Abstractions;
using InterviewDemo.DTO;
using InterviewDemo.Repository;
using Microsoft.EntityFrameworkCore;

namespace InterviewDemo.Services
{
    public class WarehouseService : BaseGenericService<WarehouseDTO>, IWarehouseService<WarehouseDTO>
    {
        public WarehouseService (DataEFContext context) : base(new WarehouseRepository(context)) { }
    }
}
