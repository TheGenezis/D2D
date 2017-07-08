using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using D2D.MultiTenancy.Dto;

namespace D2D.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
