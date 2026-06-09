namespace IT_Asset_Management.DTO
{
    public class EquipmentResponseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
    }
}
