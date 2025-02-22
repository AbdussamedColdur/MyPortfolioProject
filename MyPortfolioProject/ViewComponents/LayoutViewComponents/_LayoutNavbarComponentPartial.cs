using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;

namespace MyPortfolioProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial: ViewComponent
    {
        MyPortfolioContext _portfoliocontext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = _portfoliocontext.ToDoLists.Where(x => x.status == false).Count();
            var values = _portfoliocontext.ToDoLists.Where(x => x.status == false).ToList();
            return View(values);
        }
    }
}
