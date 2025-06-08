﻿namespace AccountManagementSystem.DomainModels.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
        public string FullName => $"{FirstName} {LastName}".Trim();
        public string RolesDisplay => string.Join(", ", Roles);
    }
}
