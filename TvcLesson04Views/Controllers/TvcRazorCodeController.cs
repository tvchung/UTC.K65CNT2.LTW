using Microsoft.AspNetCore.Mvc;

namespace TvcLesson04Views.Controllers
{
    public class TvcRazorCodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
