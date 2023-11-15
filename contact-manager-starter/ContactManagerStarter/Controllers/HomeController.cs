using Microsoft.AspNetCore.Mvc;

namespace ContactManagerStarter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception e)
            {
                return StatusCode(500, "An error has occured on the homepage: " + e.Message);
            }
        }
    }
}
