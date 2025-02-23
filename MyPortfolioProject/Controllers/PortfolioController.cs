using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
