using InterviewDemo.Abstractions;
using InterviewDemo.DTO;
using InterviewDemo.Model;
using InterviewDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InterviewDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly IPackageService<PackageDTO> _packageService;

        public PackageController(IPackageService<PackageDTO> packageService)
        {
            _packageService = packageService;
        }

        [Route("GetAllPackages")]
        [HttpPost]
        public async Task<IActionResult> GetAllPackages()
        {
            return Ok(await _packageService.GetAll());
        }

        [Route("GetPackage")]
        [HttpPost]
        public async Task<IActionResult> GetPackage([FromBody]int? id)
        {
            return Ok(await _packageService.Get(id.Value));
        }

        [Route("AddPackage")]
        [HttpPost]
        public async Task<IActionResult> AddPackage([FromBody] PackageDTO package)
        {
            return Ok(await _packageService.Add(package));
        }

        [Route("UpdatePackage")]
        [HttpPost]
        public async Task<IActionResult> UpdatePackage([FromBody] PackageDTO package)
        {
            return Ok(await _packageService.Update(package));
        }

        [Route("DeletePackage")]
        [HttpPost]
        public async Task<IActionResult> DeletePackage([FromBody] PackageDTO package)
        {
            return Ok(await _packageService.Delete(package));
        }
    }
}
