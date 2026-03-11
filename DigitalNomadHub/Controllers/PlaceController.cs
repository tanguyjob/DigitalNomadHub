using Microsoft.AspNetCore.Mvc;

namespace DigitalNomadHub.Controllers
{
    public class PlaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
