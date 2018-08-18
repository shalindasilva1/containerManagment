using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Maersk.Configuration;

namespace Maersk.Web.Host.Startup
{
    [DependsOn(
       typeof(MaerskWebCoreModule))]
    public class MaerskWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MaerskWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MaerskWebHostModule).GetAssembly());
        }
    }
}
