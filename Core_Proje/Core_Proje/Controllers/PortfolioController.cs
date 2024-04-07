using BusinessLayer.Concrete;
using FluentValidation.Results;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.ValidationRules;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfoliomanager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            var values = portfoliomanager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(portfolio);
            if (result.IsValid)
            {
                portfoliomanager.TAdd(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }


        public IActionResult EditPortfolio(int id)
        {
            var values = portfoliomanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]

        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(portfolio);
            if (result.IsValid)
            {
                portfoliomanager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }

            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();


        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = portfoliomanager.TGetByID(id);
            portfoliomanager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
