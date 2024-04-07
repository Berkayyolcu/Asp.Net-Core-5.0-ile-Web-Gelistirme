using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        public IActionResult Index()
        {
            var values = socialMediaManager.GetList();
            return View(values);
        }

        [HttpGet]

        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia media)
        {
            media.Status = true;
            socialMediaManager.TAdd(media);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var values = socialMediaManager.TGetByID(id);
            socialMediaManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var values = socialMediaManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]

        public IActionResult EditSocialMedia(SocialMedia media)
        {
            socialMediaManager.TUpdate(media);
            return RedirectToAction("Index");
        }
    }
}
