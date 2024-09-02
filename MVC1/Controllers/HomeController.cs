using Microsoft.AspNetCore.Mvc;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } public IActionResult about()
        {
            return View();
        } public IActionResult contact()
        {
            return View();
        } public IActionResult privacy()
        {
            return View();
        }
    }
}
