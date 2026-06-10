using System.ComponentModel.DataAnnotations;

namespace IT_Asset_Management.DTO
{
    public class CreateEquipmentDTO
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string SerialNumber { get; set; } = string.Empty;
        public Entities.EquipmentType Type { get; set; } = Entities.EquipmentType.Other;
    }
}
