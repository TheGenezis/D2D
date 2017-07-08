using System.Threading.Tasks;
using Abp.Application.Services;
using D2D.Sessions.Dto;

namespace D2D.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
