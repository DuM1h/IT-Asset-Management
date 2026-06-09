namespace IT_Asset_Management.DTO
{
    public class EmployeeResponseDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;

        public List<EquipmentResponseDTO> Equipments { get; set; } = new();
    }
}
