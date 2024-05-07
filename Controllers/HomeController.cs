using Microsoft.AspNetCore.Mvc;

namespace WebPurpleBuz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
