using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;

namespace MyPortfolioProject.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext _portfoliocontext = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = _portfoliocontext.Skills.Count();
            ViewBag.v2 = _portfoliocontext.Messages.Count();
            ViewBag.v3 = _portfoliocontext.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = _portfoliocontext.Messages.Where(x => x.IsRead == true).Count();
            return View();
        }
    }
}
