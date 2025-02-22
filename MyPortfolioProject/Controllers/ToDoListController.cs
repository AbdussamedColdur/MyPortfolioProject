using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;
using MyPortfolioProject.DAL.Entities;

namespace MyPortfolioProject.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext _portfoliocontext = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = _portfoliocontext.ToDoLists.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.status = false;
            _portfoliocontext.ToDoLists.Add(toDoList);
            _portfoliocontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteToDoList(int id)
        {
            var value = _portfoliocontext.ToDoLists.Find(id);
            _portfoliocontext.ToDoLists.Remove(value);
            _portfoliocontext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = _portfoliocontext.ToDoLists.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            _portfoliocontext.ToDoLists.Update(toDoList);
            _portfoliocontext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToTrue(int id)
        {
            var value = _portfoliocontext.ToDoLists.Find(id);
            value.status = true;
            _portfoliocontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            var value = _portfoliocontext.ToDoLists.Find(id);
            value.status = false;
            _portfoliocontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
