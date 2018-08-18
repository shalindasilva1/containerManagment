using System.Threading.Tasks;
using Abp.Application.Services;
using Maersk.Sessions.Dto;

namespace Maersk.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
