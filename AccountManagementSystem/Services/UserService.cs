using AccountManagementSystem.DataAccess.Repositories.RepositoryInterface;
using AccountManagementSystem.DomainModels.ViewModels;
using AccountManagementSystem.Services.ServiceInterface;

namespace AccountManagementSystem.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<List<UserWithRolesDto>> GetAllUsersWithRolesAsync()
        {
            //code
            return await _userRepository.GetAllUsersWithRolesAsync();
        }
        public async Task<List<UserModulePermissionDto>> GetUserPermissionsAsync(string userId)
        {
            //code
            return await _userRepository.GetUserPermissionsAsync(userId);
        }
        public async Task<List<UserViewModel>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersWithRolesAsync();
            var userViewModels = new List<UserViewModel>();

            //code

            return userViewModels;
        }
    }
}
