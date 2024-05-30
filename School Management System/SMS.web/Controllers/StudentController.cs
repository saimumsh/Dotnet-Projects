using Microsoft.AspNetCore.Mvc;

namespace SMS.web.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
