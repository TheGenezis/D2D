using Abp.AspNetCore.Mvc.Authorization;
using D2D.Authorization;
using D2D.Controllers;
using D2D.MultiTenancy;
using Microsoft.AspNetCore.Mvc;

namespace D2D.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : D2DControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}