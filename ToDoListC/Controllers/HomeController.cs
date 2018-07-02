using Microsoft.AspNetCore.Mvc;

namespace ToDoListC.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
