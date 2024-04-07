using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
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
