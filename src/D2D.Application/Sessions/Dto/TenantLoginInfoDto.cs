using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using D2D.MultiTenancy;

namespace D2D.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}