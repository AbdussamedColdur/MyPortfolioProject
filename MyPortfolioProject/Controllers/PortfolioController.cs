using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;
using MyPortfolioProject.DAL.Entities;

namespace MyPortfolioProject.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioContext _portfoliocontext = new MyPortfolioContext();
        public IActionResult PortfolioList()
        {
            var values = _portfoliocontext.Portfolios.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio Portfolio)
        {
            _portfoliocontext.Portfolios.Add(Portfolio);
            _portfoliocontext.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = _portfoliocontext.Portfolios.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio Portfolio)
        {
            _portfoliocontext.Portfolios.Update(Portfolio);
            _portfoliocontext.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = _portfoliocontext.Portfolios.Find(id);
            _portfoliocontext.Portfolios.Remove(value);
            _portfoliocontext.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
