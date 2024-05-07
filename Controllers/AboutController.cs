using Microsoft.AspNetCore.Mvc;

namespace WebPurpleBuz.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
