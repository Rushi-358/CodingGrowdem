using Microsoft.AspNetCore.Mvc;

namespace CodingGrowdemo.Controllers
{
    public class DemoController1 : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("DemoController1 Index action called.");
            return View();
        }
    }
}
