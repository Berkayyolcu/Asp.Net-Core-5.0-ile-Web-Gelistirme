using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Proje.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        MessageManager messagemanager = new MessageManager(new
EfMessageDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    messagemanager.TAdd(p);
        //    return View();
        //}


    
    }
}
