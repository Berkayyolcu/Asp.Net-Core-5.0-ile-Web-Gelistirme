using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListManager todolistmanager = new ToDoListManager(new EfToDoListDal());

        public IViewComponentResult Invoke()
        {
            var values = todolistmanager.GetList();
            return View(values);
        }
    }
}
