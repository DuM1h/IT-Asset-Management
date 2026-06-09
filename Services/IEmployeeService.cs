namespace IT_Asset_Management.Services
{
    public interface IEmployeeService
    {
        public Task<Guid> CreateEmployeeAsync(DTO.CreateEmployeeDTO employeeDto);
        public Task<DTO.EmployeeResponseDTO?> GetEmployeeByIdAsync(Guid employeeId);
    }
}
