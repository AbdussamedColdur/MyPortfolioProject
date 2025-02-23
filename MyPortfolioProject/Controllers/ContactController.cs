using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
