using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult SkillList()
        {
            return View();
        }
    }
}
