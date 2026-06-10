namespace IT_Asset_Management.Services
{
    public interface IEquipmentService
    {
        public Task<Guid> CreateEquipmentAsync(DTO.CreateEquipmentDTO equipmentDto);
        public Task AssignEquipmentToEmployee(Guid equipmentId, Guid employeeId);
    }
}
