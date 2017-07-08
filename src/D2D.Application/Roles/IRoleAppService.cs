using System.Threading.Tasks;
using Abp.Application.Services;
using D2D.Roles.Dto;

namespace D2D.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
