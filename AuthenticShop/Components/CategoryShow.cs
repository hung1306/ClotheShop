using AuthenticShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticShop.Components
{
    public class CategoryShow : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public CategoryShow(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View(_context.Categories.ToList());
        }
    }
}
