using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Maersk.EntityFrameworkCore
{
    public static class MaerskDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MaerskDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MaerskDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
