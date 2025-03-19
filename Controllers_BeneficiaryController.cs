using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using EducationalNGO.Data;
using EducationalNGO.Models;

namespace EducationalNGO.Controllers
{
    public class BeneficiaryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Beneficiary
        public ActionResult Index()
        {
            return View(db.Beneficiaries.ToList());
        }

        // GET: Beneficiary/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Beneficiary/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,DateOfBirth,ContactNumber,Address,EducationLevel")] Beneficiary beneficiary)
        {
            if (ModelState.IsValid)
            {
                beneficiary.EnrollmentDate = DateTime.UtcNow;
                beneficiary.Status = "Active";
                db.Beneficiaries.Add(beneficiary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(beneficiary);
        }

        // GET: Beneficiary/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beneficiary beneficiary = db.Beneficiaries.Find(id);
            if (beneficiary == null)
            {
                return HttpNotFound();
            }
            return View(beneficiary);
        }

        // POST: Beneficiary/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,DateOfBirth,ContactNumber,Address,EducationLevel,Status")] Beneficiary beneficiary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beneficiary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(beneficiary);
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