using Microsoft.EntityFrameworkCore;

namespace IT_Asset_Management.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AssetDbContext _context;

        public EmployeeService(AssetDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreateEmployeeAsync(DTO.CreateEmployeeDTO employeeDto)
        {
            var employee = new Entities.Employee
            {
                Id = Guid.NewGuid(),
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                Department = employeeDto.Department
            };
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee.Id;
        }

        public async Task<DTO.EmployeeResponseDTO?> GetEmployeeByIdAsync(Guid employeeId)
        {
            var employee = await _context.Employees.Include(e => e.Equipments).FirstOrDefaultAsync(e => e.Id == employeeId);
            if (employee == null)
                return null;

            return new DTO.EmployeeResponseDTO
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Department = employee.Department,
                Equipments = employee.Equipments.Select(eq => new DTO.EquipmentResponseDTO
                {
                    Id = eq.Id,
                    Name = eq.Name,
                    SerialNumber = eq.SerialNumber,
                    Type = eq.Type.ToString(),
                }).ToList()
            };
        }
    }
}
