using AccountManagementSystem.DomainModels.ViewModels;

namespace AccountManagementSystem.DataAccess.Repositories.RepositoryInterface
{
    public class IUserRepository
    {
        Task<List<UserWithRolesDto>> GetAllUsersWithRolesAsync();
        Task<List<UserWithRolesDto>> GetUserByIdWithRolesAsync(string userId);
        Task<List<UserModulePermissionDto>> GetUserPermissionsAsync(string userId);
    }
}
