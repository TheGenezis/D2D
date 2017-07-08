using D2D.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace D2D.Web.Host.Controllers
{
    public class AntiForgeryController : D2DControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}