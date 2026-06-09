using Microsoft.AspNetCore.Mvc;
using IT_Asset_Management.DTO;
using IT_Asset_Management.Services;

namespace IT_Asset_Management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssetController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public AssetController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("employee")]
        public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployeeDTO employeeDto)
        {
            var employeeId = await _employeeService.CreateEmployeeAsync(employeeDto);
            return Ok(new { Id = employeeId });
        }

        [HttpGet("employee/{id}")]
        public async Task<IActionResult> GetEmployeeById(Guid id)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(id);
            if (employee == null)
                return NotFound(new { Message = $"Співробітника з ID {id} не знайдено" });

            return Ok(employee);
        }
    }
}
