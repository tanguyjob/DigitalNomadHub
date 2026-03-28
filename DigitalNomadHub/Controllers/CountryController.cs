using DigitalNomadHub.Data;
using DigitalNomadHub.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalNomadHub.Controllers
{
    public class CountryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CountryController(ApplicationDbContext db) { 
            _db=db;
        }
        public IActionResult Index()
        {
            List<Country> objCountryList = _db.Countries.ToList();
            return View(objCountryList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
