using Microsoft.AspNetCore.Mvc;

namespace SampleDemoApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
