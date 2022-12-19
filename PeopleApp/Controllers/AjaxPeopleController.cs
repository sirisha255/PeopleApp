using Microsoft.AspNetCore.Mvc;

namespace PeopleApp.Controllers
{
    public class AjaxPeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
