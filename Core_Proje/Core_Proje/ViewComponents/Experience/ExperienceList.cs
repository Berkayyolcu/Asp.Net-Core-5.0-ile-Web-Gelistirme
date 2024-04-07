using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager experiencemanager = new ExperienceManager(new
        EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = experiencemanager.GetList();
            return View(values);
        }
    }
}
