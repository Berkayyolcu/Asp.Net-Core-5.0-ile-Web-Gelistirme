using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messageManager.GetList();
            return View();
        }

        public IActionResult DeleteContact(int id)
        {
            var values = messageManager.TGetByID(id);
            messageManager.TDelete(values);
            return RedirectToAction("Index");
        }

        public IActionResult ContactDetails(int id)
        {
            var values = messageManager.TGetByID(id);
            return View(values);
        }
    }
}
