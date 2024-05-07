using Microsoft.AspNetCore.Mvc;

namespace WebPurpleBuz.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
