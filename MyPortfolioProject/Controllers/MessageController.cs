using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;

namespace MyPortfolioProject.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext _portfolioContext = new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values = _portfolioContext.Messages.ToList();
            return View(values);
        }
    }
}
