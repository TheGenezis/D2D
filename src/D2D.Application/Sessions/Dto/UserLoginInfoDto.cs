using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using D2D.Authorization.Users;
using D2D.Users;

namespace D2D.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
