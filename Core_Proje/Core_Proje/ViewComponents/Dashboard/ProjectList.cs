using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class ProjectList:ViewComponent
    {
        PortfolioManager portfoliomanager = new PortfolioManager(new EfPortfolioDal());
     
        public IViewComponentResult Invoke()
        {
            var values = portfoliomanager.GetList();
            return View(values);
        }
    }
}
