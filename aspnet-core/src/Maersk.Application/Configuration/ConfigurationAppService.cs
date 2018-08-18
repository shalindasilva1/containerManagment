using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Maersk.Configuration.Dto;

namespace Maersk.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MaerskAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
