using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using D2D.Authorization;
using D2D.Controllers;
using D2D.Users;
using Microsoft.AspNetCore.Mvc;

namespace D2D.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : D2DControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }
}