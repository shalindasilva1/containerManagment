using System.Threading.Tasks;
using Abp.Application.Services;
using Maersk.Authorization.Accounts.Dto;

namespace Maersk.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
