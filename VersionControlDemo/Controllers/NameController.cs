using Microsoft.AspNetCore.Mvc;

namespace VersionControlDemo.Controllers
{
    public class NameController : Controller
    {
        public IActionResult Welcome(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}
