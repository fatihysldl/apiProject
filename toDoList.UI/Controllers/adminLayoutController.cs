using Microsoft.AspNetCore.Mvc;

namespace toDoList.UI.Controllers
{
    public class adminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult scripts()
        {
            return PartialView();
        }
        public PartialViewResult head()
        {
            return PartialView();
        }
    }
}
