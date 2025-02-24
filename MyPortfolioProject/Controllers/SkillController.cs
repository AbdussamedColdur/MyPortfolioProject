using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;
using MyPortfolioProject.DAL.Entities;

namespace MyPortfolioProject.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolioContext _portfolioContext = new MyPortfolioContext();
        public IActionResult SkillList()
        {
            var values = _portfolioContext.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            _portfolioContext.Skills.Add(skill);
            _portfolioContext.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = _portfolioContext.Skills.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            _portfolioContext.Skills.Update(skill);
            _portfolioContext.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public IActionResult DeleteSkill(int id)
        {
            var value = _portfolioContext.Skills.Find(id);
            _portfolioContext.Skills.Remove(value);
            _portfolioContext.SaveChanges();
            return RedirectToAction("SkillList");
        }

    }
}
