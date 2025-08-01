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
            // Simulate database work
            System.Threading.Thread.Sleep(5000);
            ViewBag.Id = ID;
            return PartialView("~/Views/Shared/_PartialView.cshtml");
        }
    }
}