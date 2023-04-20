using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebApp.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
