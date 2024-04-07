using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactManager contactmanager = new ContactManager(new EfContactDal());

        public IViewComponentResult Invoke()
        {
            var values = contactmanager.GetList();
            return View(values);
        }
    }
}
