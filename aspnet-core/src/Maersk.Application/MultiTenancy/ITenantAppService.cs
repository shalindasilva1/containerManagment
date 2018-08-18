using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Maersk.MultiTenancy.Dto;

namespace Maersk.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
