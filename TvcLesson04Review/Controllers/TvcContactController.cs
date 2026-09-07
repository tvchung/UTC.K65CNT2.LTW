using Microsoft.AspNetCore.Mvc;

namespace TvcLesson04Review.Controllers
{
    public class TvcContactController : Controller
    {
        public IActionResult Index()
        {
            ViewData["hoten"] = "Trịnh Văn Chung";
            ViewBag.age = "20++";
            TempData["email"] = "chungtrinhj@gmail.com";
            return View();
        }
    }
}
