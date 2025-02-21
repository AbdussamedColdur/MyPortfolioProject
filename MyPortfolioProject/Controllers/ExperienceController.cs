using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;
using MyPortfolioProject.DAL.Entities;

namespace MyPortfolioProject.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext _portfolioContext = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = _portfolioContext.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            _portfolioContext.Experiences.Add(experience);
            _portfolioContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        public IActionResult DeleteExperience(int id)
        {
            var experience = _portfolioContext.Experiences.Find(id);
            _portfolioContext.Experiences.Remove(experience);
            _portfolioContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = _portfolioContext.Experiences.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            _portfolioContext.Experiences.Update(experience);
            _portfolioContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
