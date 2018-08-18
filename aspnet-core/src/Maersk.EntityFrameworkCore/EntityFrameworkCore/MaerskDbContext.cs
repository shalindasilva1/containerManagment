using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Maersk.Authorization.Roles;
using Maersk.Authorization.Users;
using Maersk.MultiTenancy;

namespace Maersk.EntityFrameworkCore
{
    public class MaerskDbContext : AbpZeroDbContext<Tenant, Role, User, MaerskDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MaerskDbContext(DbContextOptions<MaerskDbContext> options)
            : base(options)
        {
        }
    }
}
