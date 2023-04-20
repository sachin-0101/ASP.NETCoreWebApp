using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
