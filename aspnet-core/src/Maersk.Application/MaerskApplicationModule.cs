using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Maersk.Authorization;

namespace Maersk
{
    [DependsOn(
        typeof(MaerskCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MaerskApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MaerskAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MaerskApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
