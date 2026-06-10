using System.ComponentModel.DataAnnotations;

namespace IT_Asset_Management.DTO
{
    public class CreateEmployeeDTO
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Department { get; set; } = string.Empty;
    }
}
