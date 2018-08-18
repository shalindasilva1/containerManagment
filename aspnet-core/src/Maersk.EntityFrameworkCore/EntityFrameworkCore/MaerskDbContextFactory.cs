using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Maersk.Configuration;
using Maersk.Web;

namespace Maersk.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MaerskDbContextFactory : IDesignTimeDbContextFactory<MaerskDbContext>
    {
        public MaerskDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MaerskDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MaerskDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MaerskConsts.ConnectionStringName));

            return new MaerskDbContext(builder.Options);
        }
    }
}
