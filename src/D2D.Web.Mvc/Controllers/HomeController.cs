using Abp.AspNetCore.Mvc.Authorization;
using D2D.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace D2D.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : D2DControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}