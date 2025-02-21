using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;

namespace MyPortfolioProject.ViewComponents
{
    public class _SkillComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            MyPortfolioContext portfolioContext = new MyPortfolioContext();
            var values = portfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
