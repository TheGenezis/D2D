using D2D.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace D2D.Web.Controllers
{
    public class AboutController : D2DControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}