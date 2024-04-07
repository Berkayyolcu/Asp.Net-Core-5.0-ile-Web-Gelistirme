using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager skillmanager = new SkillManager(new
        EfSkillDal());

        public IViewComponentResult Invoke()
        {
            var values = skillmanager.GetList();
            return View(values);
        }
    }
}
