using Abp.Authorization;
using D2D.Authorization.Roles;
using D2D.Authorization.Users;

namespace D2D.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
