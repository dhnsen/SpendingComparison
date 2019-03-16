using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SpendingComparisonV0_1.Models;
using SpendingComparisonV0_1.Models.Multipliers;

namespace SpendingComparisonV0_1.Controllers
{
    [Authorize(Roles = "DataAdmin")]
    public class RegionMultipliersController : Controller
    {
        private StatisticsContext db = new StatisticsContext();

        // GET: RegionMultipliers
        public ActionResult Index()
        {
            var regionMultipliers = db.RegionMultipliers.Include(r => r.Region);
            return View(regionMultipliers.ToList());
        }

        // GET: RegionMultipliers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegionMultiplier regionMultiplier = db.RegionMultipliers.Find(id);
            if (regionMultiplier == null)
            {
                return HttpNotFound();
            }
            return View(regionMultiplier);
        }

        // GET: RegionMultipliers/Create
        public ActionResult Create()
        {
            ViewBag.RegionId = new SelectList(db.Regions, "RegionID", "Name");
            return View();
        }

        // POST: RegionMultipliers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MultiplierIncomeID,RegionId,RestaurantsAndDining,Groceries,RentOrMortgage,ElectricAndGas")] RegionMultiplier regionMultiplier)
        {
            if (ModelState.IsValid)
            {
                db.RegionMultipliers.Add(regionMultiplier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RegionId = new SelectList(db.Regions, "RegionID", "Name", regionMultiplier.RegionId);
            return View(regionMultiplier);
        }

        // GET: RegionMultipliers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegionMultiplier regionMultiplier = db.RegionMultipliers.Find(id);
            if (regionMultiplier == null)
            {
                return HttpNotFound();
            }
            ViewBag.RegionId = new SelectList(db.Regions, "RegionID", "Name", regionMultiplier.RegionId);
            return View(regionMultiplier);
        }

        // POST: RegionMultipliers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MultiplierIncomeID,RegionId,RestaurantsAndDining,Groceries,RentOrMortgage,ElectricAndGas")] RegionMultiplier regionMultiplier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regionMultiplier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RegionId = new SelectList(db.Regions, "RegionID", "Name", regionMultiplier.RegionId);
            return View(regionMultiplier);
        }

        // GET: RegionMultipliers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegionMultiplier regionMultiplier = db.RegionMultipliers.Find(id);
            if (regionMultiplier == null)
            {
                return HttpNotFound();
            }
            return View(regionMultiplier);
        }

        // POST: RegionMultipliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegionMultiplier regionMultiplier = db.RegionMultipliers.Find(id);
            db.RegionMultipliers.Remove(regionMultiplier);
            db.SaveChanges();
            return RedirectToAction("Index");
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
