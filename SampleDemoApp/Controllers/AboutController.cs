using Microsoft.AspNetCore.Mvc;

namespace SampleDemoApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
