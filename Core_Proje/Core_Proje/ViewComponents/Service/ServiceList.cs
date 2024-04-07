using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceManager servicemanager = new ServiceManager(new
      EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = servicemanager.GetList();
            return View(values);
        }
    }
}
