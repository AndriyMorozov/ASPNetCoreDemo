using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
