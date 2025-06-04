using Microsoft.EntityFrameworkCore;

namespace AccountManagementSystem.DataAccess.DBContext;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
}
