using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;
using MyPortfolioProject.DAL.Entities;

namespace MyPortfolioProject.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioContext _portfoliocontext = new MyPortfolioContext();
        public IActionResult FeatureList()
        {
            var values = _portfoliocontext.Features.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFeature(Feature Feature)
        {
            _portfoliocontext.Features.Add(Feature);
            _portfoliocontext.SaveChanges();
            return RedirectToAction("FeatureList");
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var value = _portfoliocontext.Features.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature Feature)
        {
            _portfoliocontext.Features.Update(Feature);
            _portfoliocontext.SaveChanges();
            return RedirectToAction("FeatureList");
        }

        public IActionResult DeleteFeature(int id)
        {
            var value = _portfoliocontext.Features.Find(id);
            _portfoliocontext.Features.Remove(value);
            _portfoliocontext.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}
