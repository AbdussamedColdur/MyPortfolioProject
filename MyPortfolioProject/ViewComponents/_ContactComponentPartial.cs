using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;

namespace MyPortfolioProject.ViewComponents
{
    public class _ContactComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            MyPortfolioContext portfolioContext = new MyPortfolioContext();
            ViewBag.contactTitle = portfolioContext.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.contactPhone = portfolioContext.Contacts.Select(x => x.Phone1).FirstOrDefault();
            ViewBag.contactEmail1 = portfolioContext.Contacts.Select(x => x.Email1).FirstOrDefault();
            ViewBag.contactEmail2 = portfolioContext.Contacts.Select(x => x.Email2).FirstOrDefault();
            ViewBag.contactDescription = portfolioContext.Contacts.Select(x => x.Description).FirstOrDefault();
            ViewBag.contactAddress = portfolioContext.Contacts.Select(x => x.Address).FirstOrDefault();
            return View();
        }
    }
}
