using System.ComponentModel.DataAnnotations;

namespace IT_Asset_Management.Entities
{
    public class Equipment
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        [DisplayFormat(NullDisplayText = "Other")]
        public EquipmentType Type { get; set; }
        public Guid? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }

    public enum EquipmentType
    {
        Laptop,
        Desktop,
        Monitor,
        Phone,
        Other
    }
}
