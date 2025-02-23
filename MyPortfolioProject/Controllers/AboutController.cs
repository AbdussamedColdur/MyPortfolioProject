using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;
using MyPortfolioProject.DAL.Entities;

namespace MyPortfolioProject.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioContext _portfolioContext = new MyPortfolioContext();
        public IActionResult AboutList()
        {
            var values = _portfolioContext.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            _portfolioContext.Abouts.Add(about);
            _portfolioContext.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public IActionResult DeleteAbout(int id)
        {
            var value = _portfolioContext.Abouts.Find(id);
            _portfolioContext.Abouts.Remove(value);
            _portfolioContext.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = _portfolioContext.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            _portfolioContext.Abouts.Update(about);
            _portfolioContext.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public IActionResult AboutDetail(int id)
        {
            var value = _portfolioContext.Abouts.Find(id);

            return View(value);
        }
    }
}
