using Microsoft.AspNetCore.Mvc;

namespace AuthenticShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
