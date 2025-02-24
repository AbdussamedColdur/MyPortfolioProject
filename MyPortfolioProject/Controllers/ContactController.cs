using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;
using MyPortfolioProject.DAL.Entities;

namespace MyPortfolioProject.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext _portfoliocontext = new MyPortfolioContext();
        public IActionResult ContactList()
        {
            var values = _portfoliocontext.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            _portfoliocontext.Contacts.Add(contact);
            _portfoliocontext.SaveChanges();
            return RedirectToAction("ContactList");
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = _portfoliocontext.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            _portfoliocontext.Contacts.Update(contact);
            _portfoliocontext.SaveChanges();
            return RedirectToAction("ContactList");
        }

        public IActionResult DeleteContact(int id)
        {
            var value = _portfoliocontext.Contacts.Find(id);
            _portfoliocontext.Contacts.Remove(value);
            _portfoliocontext.SaveChanges();
            return RedirectToAction("ContactList");
        }

        public IActionResult ContactDetail(int id)
        {
            var value = _portfoliocontext.Contacts.Find(id);

            return View(value);
        }
    }
}
