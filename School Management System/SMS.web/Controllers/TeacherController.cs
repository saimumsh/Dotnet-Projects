using Microsoft.AspNetCore.Mvc;

namespace SMS.web.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
