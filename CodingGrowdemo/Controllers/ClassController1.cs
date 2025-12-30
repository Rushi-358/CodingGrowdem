using Microsoft.AspNetCore.Mvc;

namespace CodingGrowdemo.Controllers
{
    public class ClassController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
