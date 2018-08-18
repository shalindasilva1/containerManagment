using System.Threading.Tasks;
using Maersk.Configuration.Dto;

namespace Maersk.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
