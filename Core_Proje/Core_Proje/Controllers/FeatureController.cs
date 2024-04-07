using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featuremanager = new FeatureManager(new EfFeatureDal());

       
        public IActionResult Index()
        {
            var values = featuremanager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddFeature()
        {
            return View();
        }
        [HttpPost]

        [HttpPost]
        public IActionResult AddFeature(Feature feature)
        {
            featuremanager.TAdd(feature);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditFeature(int id)
        {
            var values = featuremanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]

        public IActionResult EditFeature(Feature feature)
        {
            featuremanager.TUpdate(feature);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteFeature(int id)
        {
            var values = featuremanager.TGetByID(id);
            featuremanager.TDelete(values);
            return RedirectToAction("Index");
        }




    }
}
