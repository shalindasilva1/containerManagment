using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Maersk.Controllers
{
    public abstract class MaerskControllerBase: AbpController
    {
        protected MaerskControllerBase()
        {
            LocalizationSourceName = MaerskConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
