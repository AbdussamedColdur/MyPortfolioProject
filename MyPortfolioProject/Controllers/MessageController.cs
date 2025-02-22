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

        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = _portfolioContext.Messages.Find(id);
            value.IsRead = true;
            _portfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = _portfolioContext.Messages.Find(id);
            value.IsRead = false;
            _portfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult DeleteMessage(int id)
        {
            var value = _portfolioContext.Messages.Find(id);
            _portfolioContext.Messages.Remove(value);
            _portfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult MessageDetail(int id)
        {
            var value = _portfolioContext.Messages.Find(id);

            return View(value);
        }
    }
}
