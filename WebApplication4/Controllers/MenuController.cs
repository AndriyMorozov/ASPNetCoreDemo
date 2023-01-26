using Microsoft.AspNetCore.Mvc;
using WebApplication4.Data;
using WebApplication4.Models.Menu;

namespace WebApplication4.Controllers
{
    public class MenuController : Controller
    {
        protected ShopDbContext shopDbContext;
        public MenuController(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            List<Item> items = shopDbContext.Menu.ToList();
            return View(items);
        }
        [HttpPost]
        public IActionResult Add(Item item)
        {
            if (item != null)
            {
                shopDbContext.Menu.Add(item);
                shopDbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
