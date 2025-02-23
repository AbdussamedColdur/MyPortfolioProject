using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;
using MyPortfolioProject.DAL.Entities;

namespace MyPortfolioProject.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPortfolioContext _portfolioContext = new MyPortfolioContext();
        public IActionResult SocialsList()
        {
            var values = _portfolioContext.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSocial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSocial(SocialMedia socialMedia)
        {
            _portfolioContext.SocialMedias.Add(socialMedia);
            _portfolioContext.SaveChanges();
            return RedirectToAction("SocialsList");
        }

        public IActionResult DeleteSocial(int id)
        {
            var value = _portfolioContext.SocialMedias.Find(id);
            _portfolioContext.SocialMedias.Remove(value);
            _portfolioContext.SaveChanges();
            return RedirectToAction("SocialsList");
        }

        [HttpGet]
        public IActionResult UpdateSocial(int id)
        {
            var value = _portfolioContext.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSocial(SocialMedia socialMedia)
        {
            _portfolioContext.SocialMedias.Update(socialMedia);
            _portfolioContext.SaveChanges();
            return RedirectToAction("SocialsList");
        }
    }
}
