using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace D2D.Controllers
{
    public abstract class D2DControllerBase: AbpController
    {
        protected D2DControllerBase()
        {
            LocalizationSourceName = D2DConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}