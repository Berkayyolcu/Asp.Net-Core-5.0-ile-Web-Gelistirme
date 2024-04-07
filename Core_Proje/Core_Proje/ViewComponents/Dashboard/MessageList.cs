using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
            public IViewComponentResult Invoke()
            {

            var values = messageManager.GetList().Take(5).ToList();
                return View();
            }
        }
}
