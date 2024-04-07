using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
         AboutManager aboutmanager = new AboutManager(new
    EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutmanager.GetList();
            return View(values);
        }
    }
}
