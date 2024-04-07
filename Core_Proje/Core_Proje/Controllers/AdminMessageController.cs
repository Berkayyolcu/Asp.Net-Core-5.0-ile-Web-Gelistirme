using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Core_Proje.Controllers
{
    public class AdminMessageController : Controller
    {

        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }

        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            return View(values);
        }

        public IActionResult AdminMessageDelete(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            writerMessageManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AdminMessageAdd()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AdminMessageAdd(WriterMessage writer)
        {
            writer.Sender = "admin@gmail.com";
            writer.SenderName = "Admin";
            writer.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == writer.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writer.ReceiverName = usernamesurname;
            writerMessageManager.TAdd(writer);
            return RedirectToAction("SenderMessageList");
        }



    }
}
