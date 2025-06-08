using AccountManagementSystem.DataAccess.DBContext;
using AccountManagementSystem.DataAccess.Repositories.RepositoryInterface;
using AccountManagementSystem.DomainModels.ViewModels;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AccountManagementSystem.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserWithRolesDto>> GetAllUsersWithRolesAsync()
        {
            using var connection = new SqlConnection(_context);
            var result = await connection.QueryAsync<UserWithRolesDto>("sp_GetAllUsersWithRoles", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

        public async Task<List<UserWithRolesDto>> GetUserByIdWithRolesAsync(string userId)
        {
            using var connection = new SqlConnection(_context);
            var parameters = new { UserId = userId };
            var result = await connection.QueryAsync<UserWithRolesDto>("sp_GetUserByIdWithRoles", parameters, commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

        public async Task<List<UserModulePermissionDto>> GetUserPermissionsAsync(string userId)
        {
            using var connection = new SqlConnection(_context);
            var parameters = new { UserId = userId };
            var result = await connection.QueryAsync<UserModulePermissionDto>("sp_GetUserPermissions", parameters, commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
