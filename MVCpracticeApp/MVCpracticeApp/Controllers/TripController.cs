using Microsoft.AspNetCore.Mvc;
using MVCpracticeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCpracticeApp.Controllers
{
    [Route("trip")]
    public class TripController : Controller
    {
        private readonly TripDataDbContext _db;
        public TripController(TripDataDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            var trips = _db.Trips.OrderByDescending(x => x.StartDate).Take(5).ToArray();
            return View(trips);
        }

     
        [Route("{id}")]
        public IActionResult trip(int Id)
        {
            var trip = _db.Trips.FirstOrDefault(x => x.Id == Id);
            return View(trip);
        }

        [Route("delete/{id}")]
       
        public IActionResult delete (int Id)
        {
            var trip = _db.Trips.FirstOrDefault(x => x.Id == Id);
            _db.Trips.Remove(trip);
            _db.SaveChanges();
            return RedirectToAction("Index", "trip");
        }


        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [Route("Create")]
        public IActionResult Create(Trip trip)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _db.Trips.Add(trip);
            _db.SaveChanges();
            return RedirectToAction("trip", "trip", new { Id = trip.Id });
        }
    }
}
