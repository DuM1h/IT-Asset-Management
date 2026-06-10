using Microsoft.AspNetCore.Mvc;
using IT_Asset_Management.Services;
using IT_Asset_Management.DTO;
using IT_Asset_Management.Exceptions;

namespace IT_Asset_Management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;

        public EquipmentController(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEquipment([FromBody] CreateEquipmentDTO equipmentDto)
        {
            var equipmentId = await _equipmentService.CreateEquipmentAsync(equipmentDto);
            return Ok(new { Id = equipmentId });
        }

        [HttpPut]
        public async Task<IActionResult> AssignEquipmentToEmployee(Guid equipmentId, Guid employeeId)
        {
            await _equipmentService.AssignEquipmentToEmployee(equipmentId, employeeId);
            return Ok(new { Message = "Обладнання успішно призначено співробітнику" });
        }
    }
}
