using AuthenticShop.Data;
using AuthenticShop.Infrastructure;
using AuthenticShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticShop.Components
{
    public class CartWidget : ViewComponent
    {
  
        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}
