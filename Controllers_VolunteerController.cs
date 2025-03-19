using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using EducationalNGO.Data;
using EducationalNGO.Models;

namespace EducationalNGO.Controllers
{
    public class VolunteerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Volunteer
        public ActionResult Index()
        {
            return View(db.Volunteers.ToList());
        }

        // GET: Volunteer/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Email,Phone,Skills,AvailabilityStatus")] Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                volunteer.JoinDate = DateTime.Now;
                db.Volunteers.Add(volunteer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(volunteer);
        }

        // GET: Volunteer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Volunteer volunteer = db.Volunteers.Find(id);
            if (volunteer == null)
            {
                return HttpNotFound();
            }
            return View(volunteer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Phone,Skills,AvailabilityStatus,JoinDate")] Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(volunteer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(volunteer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}