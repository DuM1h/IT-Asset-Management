namespace IT_Asset_Management.DTO
{
    [Serializable]
    public class CreateEmployeeDTO
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
    }
}
