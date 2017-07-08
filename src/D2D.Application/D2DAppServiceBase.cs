using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using D2D.MultiTenancy;
using Abp.Runtime.Session;
using Abp.IdentityFramework;
using D2D.Authorization.Users;
using Microsoft.AspNetCore.Identity;

namespace D2D
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class D2DAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected D2DAppServiceBase()
        {
            LocalizationSourceName = D2DConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}