using AutoMapper;
using InterviewDemo.Abstractions;
using InterviewDemo.DTO;
using InterviewDemo.Repository;
using Microsoft.EntityFrameworkCore;

namespace InterviewDemo.Services
{
    public class WarehouseService : BaseGenericService<WarehouseDTO>, IWarehouseService<WarehouseDTO>
    {
        public WarehouseService (DataEFContext context, IMapper mapper) : base(new WarehouseRepository(context, mapper), mapper) { }

    }
}
