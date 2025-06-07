namespace AccountManagementSystem.DomainModels
{
    public class ApplicationRole
    {
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
