using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutmanager = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var values = aboutmanager.GetList();
            return View(values);
        }

        //[HttpGet]
        //public IActionResult AddAbout()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult AddAbout(About about)
        //{
        //    aboutmanager.TAdd(about);
        //    return RedirectToAction("Index");
        //}

        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var values = aboutmanager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            aboutmanager.TUpdate(about);
            return RedirectToAction("Index");
        }

        //public IActionResult DeleteAbout(int id)
        //{
        //    var values = aboutmanager.TGetByID(id);
        //    aboutmanager.TDelete(values);
        //    return RedirectToAction("Index");
        //}

    }
}
