using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            //TO DO
            using(var db = new BandMembersDbContext())
            {
                var bands = db.Banbds.ToList();
                return View(bands);
            }

        }

        [HttpGet]
        public IActionResult create()
        {
            //TO DO
            using(var db = new BandMembersDbContext())
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult create(Band band)
        {
            //TO DO
            using(var db = new BandMembersDbContext())
            {
                if (ModelState.IsValid)
                {
                    db.Banbds.Add(band);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult edit(int id)
        {
            //TO DO
            using(var db = new BandMembersDbContext())
            {
                Band oldBand = db.Banbds.Find(id);
                return View(oldBand);
            }
        }

        [HttpPost]
        public IActionResult edit(Band band)
        {
            //TO DO
            using(var db = new BandMembersDbContext())
            {
                db.Banbds.Update(band);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult delete(int id)
        {
            //TO DO
            using(var db = new BandMembersDbContext())
            {
                var oldBand = db.Banbds.Find(id);
                return View(oldBand);
            }
        }

        [HttpPost]
        public IActionResult delete(Band band)
        {
            //TO DO
            using(var db = new BandMembersDbContext())
            {
                db.Banbds.Remove(band);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}