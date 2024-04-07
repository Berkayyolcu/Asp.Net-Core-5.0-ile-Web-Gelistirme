using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featuremanager = new FeatureManager(new
            EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featuremanager.GetList();
            return View(values);
        }
    }
}
