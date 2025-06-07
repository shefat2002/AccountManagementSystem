using Microsoft.AspNetCore.Identity;

namespace AccountManagementSystem.DomainModels
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        //public bool IsActive { get; set; } = true;
        public string FullName => $"{FirstName} {LastName}";
    }
}
