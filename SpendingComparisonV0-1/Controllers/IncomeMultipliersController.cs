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
    public class IncomeMultipliersController : Controller
    {
        private StatisticsContext db = new StatisticsContext();

        // GET: IncomeMultipliers
        public ActionResult Index()
        {
            var incomeMultipliers = db.IncomeMultipliers.Include(i => i.IncomeRange);
            return View(incomeMultipliers.ToList());
        }

        // GET: IncomeMultipliers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeMultiplier incomeMultiplier = db.IncomeMultipliers.Find(id);
            if (incomeMultiplier == null)
            {
                return HttpNotFound();
            }
            return View(incomeMultiplier);
        }

        // GET: IncomeMultipliers/Create
        public ActionResult Create()
        {
            ViewBag.IncomeRangeId = new SelectList(db.IncomeRanges, "IncomeRangeID", "ToString");
            return View();
        }

        // POST: IncomeMultipliers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MultiplierIncomeID,IncomeRangeId,RestaurantsAndDining,Groceries,RentOrMortgage,ElectricAndGas")] IncomeMultiplier incomeMultiplier)
        {
            if (ModelState.IsValid)
            {
                db.IncomeMultipliers.Add(incomeMultiplier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IncomeRangeId = new SelectList(db.IncomeRanges, "IncomeRangeID", "ToString", incomeMultiplier.IncomeRangeId);
            return View(incomeMultiplier);
        }

        // GET: IncomeMultipliers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeMultiplier incomeMultiplier = db.IncomeMultipliers.Find(id);
            if (incomeMultiplier == null)
            {
                return HttpNotFound();
            }
            ViewBag.IncomeRangeId = new SelectList(db.IncomeRanges, "IncomeRangeID", "ToString", incomeMultiplier.IncomeRangeId);
            return View(incomeMultiplier);
        }

        // POST: IncomeMultipliers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MultiplierIncomeID,IncomeRangeId,RestaurantsAndDining,Groceries,RentOrMortgage,ElectricAndGas")] IncomeMultiplier incomeMultiplier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(incomeMultiplier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IncomeRangeId = new SelectList(db.IncomeRanges, "IncomeRangeID", "ToString", incomeMultiplier.IncomeRangeId);
            return View(incomeMultiplier);
        }

        // GET: IncomeMultipliers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeMultiplier incomeMultiplier = db.IncomeMultipliers.Find(id);
            if (incomeMultiplier == null)
            {
                return HttpNotFound();
            }
            return View(incomeMultiplier);
        }

        // POST: IncomeMultipliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IncomeMultiplier incomeMultiplier = db.IncomeMultipliers.Find(id);
            db.IncomeMultipliers.Remove(incomeMultiplier);
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
