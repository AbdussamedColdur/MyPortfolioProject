using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;

namespace MyPortfolioProject.ViewComponents
{
    public class _ExperinceComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            MyPortfolioContext portfolioContext = new MyPortfolioContext();
            var values = portfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
