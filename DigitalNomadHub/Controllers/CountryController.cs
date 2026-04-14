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

        [HttpPost]
        public IActionResult Create(Country obj)
        {
            if (ModelState.IsValid)
            {
                _db.Countries.Add(obj);
                _db.SaveChanges();
                TempData["Success"] = "Coutry created successfully";
                return RedirectToAction("Index", "Country");
            }
            return View();
            
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                Country countryFromDb = _db.Countries.Find(id);
                if (countryFromDb==null)
                {
                    return NotFound();
                }

                return View(countryFromDb);
            }
        }

        [HttpPost]
        public IActionResult Edit(Country obj)
        {
            if (ModelState.IsValid)
            {
                _db.Countries.Update(obj);
                _db.SaveChanges();
                TempData["Success"] = "Coutry updated successfully";
                return RedirectToAction("Index", "Country");
            }
            return View();

        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                Country countryFromDb = _db.Countries.Find(id);
                if (countryFromDb == null)
                {
                    return NotFound();
                }

                return View(countryFromDb);
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            Country? obj = _db.Countries.Find(id);
            if (obj == null)
                { return NotFound(); }
            _db.Countries.Remove(obj);
            _db.SaveChanges();
            TempData["Success"] = "Coutry deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
