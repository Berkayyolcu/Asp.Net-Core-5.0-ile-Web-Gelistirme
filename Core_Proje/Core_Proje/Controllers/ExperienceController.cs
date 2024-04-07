using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    //[Authorize(Roles ="Admin")]
    public class ExperienceController : Controller
    {
        ExperienceManager experiencemanager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = experiencemanager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience() 
        {      
        return View();       
        }
        [HttpPost]

        public IActionResult AddExperience(Experience experience)
        {
            experiencemanager.TAdd(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var values = experiencemanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]

        public IActionResult EditExperience(Experience experience)
        {
            experiencemanager.TUpdate(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = experiencemanager.TGetByID(id);
            experiencemanager.TDelete(values);
            return RedirectToAction("Index");
        }

    }
}
