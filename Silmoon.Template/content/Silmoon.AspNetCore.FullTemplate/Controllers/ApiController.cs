using Microsoft.AspNetCore.Mvc;

namespace Silmoon.AspNetCore.FullTemplate.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
