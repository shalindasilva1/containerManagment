using Microsoft.AspNetCore.Antiforgery;
using Maersk.Controllers;

namespace Maersk.Web.Host.Controllers
{
    public class AntiForgeryController : MaerskControllerBase
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
