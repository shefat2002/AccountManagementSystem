using AccountManagementSystem.DomainModels.ViewModels;

namespace AccountManagementSystem.Services.ServiceInterface
{
    public interface IUserService
    {
        Task<List<UserViewModel>> GetAllUsersAsync();
        Task<List<UserWithRolesDto>> GetAllUsersWithRolesAsync();
        Task<List<UserModulePermissionDto>> GetUserPermissionsAsync(string userId);
    }
}