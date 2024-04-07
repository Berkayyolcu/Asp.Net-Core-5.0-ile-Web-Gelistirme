using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Core_Proje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillmanager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = skillmanager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddSkill(Skill skill)
        {
            skillmanager.TAdd(skill);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var values = skillmanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillmanager.TUpdate(skill);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = skillmanager.TGetByID(id);
            skillmanager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
