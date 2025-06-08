﻿namespace AccountManagementSystem.DomainModels.ViewModels
{
    public class UserWithRolesDto
    {
        public string Id { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string RoleName { get; set; } = string.Empty;
    }
}
