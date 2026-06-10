using Microsoft.EntityFrameworkCore;
using IT_Asset_Management.DTO;
using IT_Asset_Management.Exceptions;

namespace IT_Asset_Management.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly AssetDbContext _context;

        public EquipmentService(AssetDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreateEquipmentAsync(CreateEquipmentDTO equipmentDto)
        {
            var equipment = new Entities.Equipment
            {
                Id = Guid.NewGuid(),
                Name = equipmentDto.Name,
                SerialNumber = equipmentDto.SerialNumber,
                Type = equipmentDto.Type,
            };
            _context.Equipments.Add(equipment);
            await _context.SaveChangesAsync();
            return equipment.Id;
        }

        public async Task AssignEquipmentToEmployee(Guid equipmentId, Guid employeeId)
        {
            var equipment = await _context.Equipments.FindAsync(equipmentId);
            if (equipment == null)
                throw new NotFoundException("Техніки з таким ID не знайдено");

            var employeeExists = await _context.Employees.AnyAsync(e => e.Id == employeeId);
            if (!employeeExists)
            {
                throw new NotFoundException("Співробітника з таким ID не знайдено");
            }

            if (equipment.EmployeeId == employeeId)
            {
                throw new AlreadyTakenException("Ця техніка вже призначена цьому співробітнику");
            }
            equipment.EmployeeId = employeeId;

            await _context.SaveChangesAsync();
        }
    }
}
