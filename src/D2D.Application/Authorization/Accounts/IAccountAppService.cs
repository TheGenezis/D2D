using System.Threading.Tasks;
using Abp.Application.Services;
using D2D.Authorization.Accounts.Dto;

namespace D2D.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
