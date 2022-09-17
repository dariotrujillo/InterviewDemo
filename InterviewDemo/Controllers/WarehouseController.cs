using InterviewDemo.Abstractions;
using InterviewDemo.DTO;
using InterviewDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InterviewDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseService<WarehouseDTO> _warehouseService;

        public WarehouseController(IWarehouseService<WarehouseDTO> warehouseService)
        {
            _warehouseService = warehouseService;
        }

        [Route("GetAllWarehouses")]
        [HttpPost]
        public async Task<IActionResult> GetAllWarehouses()
        {
            return Ok(await _warehouseService.GetAll());
        }

        [Route("GetWarehouse")]
        [HttpPost]
        public async Task<IActionResult> GetWarehouse([FromBody]int Id)
        {
            return Ok(await _warehouseService.Get(Id));
        }

        [Route("AddWarehouse")]
        [HttpPost]
        public async Task<IActionResult> AddWarehouse([FromBody] WarehouseDTO warehouse)
        {
            return Ok(await _warehouseService.Add(warehouse));
        }

        [Route("UpdateWarehouse")]
        [HttpPost]
        public async Task<IActionResult> UpdateWarehouse([FromBody] WarehouseDTO warehouse)
        {
            return Ok(await _warehouseService.Update(warehouse));
        }

        [Route("DeleteWarehouse")]
        [HttpPost]
        public async Task<IActionResult> DeleteWarehouse([FromBody] WarehouseDTO warehouse)
        {
            return Ok(await _warehouseService.Delete(warehouse));
        }
    }
}
