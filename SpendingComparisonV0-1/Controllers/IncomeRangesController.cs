using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SpendingComparisonV0_1.Models;
using SpendingComparisonV0_1.Models.StatisticalSupport;

namespace SpendingComparisonV0_1.Controllers
{
    [Authorize(Roles = "DataAdmin")]
    public class IncomeRangesController : Controller
    {
        private StatisticsContext db = new StatisticsContext();

        // GET: IncomeRanges
        public ActionResult Index()
        {
            return View(db.IncomeRanges.ToList());
        }

        // GET: IncomeRanges/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeRange incomeRange = db.IncomeRanges.Find(id);
            if (incomeRange == null)
            {
                return HttpNotFound();
            }
            return View(incomeRange);
        }

        // GET: IncomeRanges/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IncomeRanges/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IncomeRangeID,BottomIncomeRange,TopIncomeRange")] IncomeRange incomeRange)
        {
            if (ModelState.IsValid)
            {
                db.IncomeRanges.Add(incomeRange);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(incomeRange);
        }

        // GET: IncomeRanges/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeRange incomeRange = db.IncomeRanges.Find(id);
            if (incomeRange == null)
            {
                return HttpNotFound();
            }
            return View(incomeRange);
        }

        // POST: IncomeRanges/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IncomeRangeID,BottomIncomeRange,TopIncomeRange")] IncomeRange incomeRange)
        {
            if (ModelState.IsValid)
            {
                db.Entry(incomeRange).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(incomeRange);
        }

        // GET: IncomeRanges/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeRange incomeRange = db.IncomeRanges.Find(id);
            if (incomeRange == null)
            {
                return HttpNotFound();
            }
            return View(incomeRange);
        }

        // POST: IncomeRanges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IncomeRange incomeRange = db.IncomeRanges.Find(id);
            db.IncomeRanges.Remove(incomeRange);
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
