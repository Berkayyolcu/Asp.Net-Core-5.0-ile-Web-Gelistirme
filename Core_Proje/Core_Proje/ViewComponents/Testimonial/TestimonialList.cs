using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        TestimonialManager testimonialmanager = new TestimonialManager(new
      EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialmanager.GetList();
            return View(values);
        }
    }
}
