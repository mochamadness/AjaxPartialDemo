using Microsoft.AspNetCore.Mvc;

namespace AjaxPartialDemo.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(int ID)
        {
            // simulate some work
            ViewBag.Id = ID;
            return PartialView("~/Views/Shared/_PartialView.cshtml");
        }
    }
}

