using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class SlideList : ViewComponent
    {
        PortfolioManager portfoliomanager = new PortfolioManager(new
      EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values = portfoliomanager.GetList();
            return View(values);
        }

    }
}

