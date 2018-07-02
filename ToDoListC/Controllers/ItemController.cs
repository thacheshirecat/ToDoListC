using Microsoft.AspNetCore.Mvc;
using ToDoListC.Models;

namespace ToDoListC.Controllers
{
    public class ItemsController : Controller
    {

        [HttpGet("/items")]
        public ActionResult Index()
        {
            Item newItem = new Item(Request.Query["new-item"]);
            return View(newItem);
        }

        [HttpGet("/items/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
    }
}
