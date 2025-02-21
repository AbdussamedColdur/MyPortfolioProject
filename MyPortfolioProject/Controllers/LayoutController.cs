using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class Layout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
