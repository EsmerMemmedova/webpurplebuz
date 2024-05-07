using Microsoft.AspNetCore.Mvc;

namespace WebPurpleBuz.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
