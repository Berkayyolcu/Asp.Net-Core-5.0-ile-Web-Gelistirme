using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ContactSubPlaceController : Controller
    {
        ContactManager contactmanager = new ContactManager(new EfContactDal());

        [HttpGet]
        public IActionResult Index()
        {
            var values = contactmanager.TGetByID(1);
            return View(values);
        }
        [HttpPost]

        public IActionResult Index(Contact contact)
        {
            contactmanager.TUpdate(contact);
            return RedirectToAction("Index", "Default");
        }

    }
}
