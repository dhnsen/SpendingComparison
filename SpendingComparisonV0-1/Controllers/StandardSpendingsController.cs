using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SpendingComparisonV0_1.Models;
using SpendingComparisonV0_1.Models.SpendingModels;

namespace SpendingComparisonV0_1.Controllers
{
    [Authorize(Roles = "DataAdmin")]
    public class StandardSpendingsController : Controller
    {
        private StatisticsContext db = new StatisticsContext();

        // GET: StandardSpendings
        public ActionResult Index()
        {
            return View(db.StandardSpendings.ToList());
        }

        // GET: StandardSpendings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StandardSpending standardSpending = db.StandardSpendings.Find(id);
            if (standardSpending == null)
            {
                return HttpNotFound();
            }
            return View(standardSpending);
        }

        // GET: StandardSpendings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StandardSpendings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StandardSpendingID,CalendarYear,RestaurantsAndDining,Groceries,RentOrMortgage,ElectricAndGas")] StandardSpending standardSpending)
        {
            if (ModelState.IsValid)
            {
                db.StandardSpendings.Add(standardSpending);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(standardSpending);
        }

        // GET: StandardSpendings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StandardSpending standardSpending = db.StandardSpendings.Find(id);
            if (standardSpending == null)
            {
                return HttpNotFound();
            }
            return View(standardSpending);
        }

        // POST: StandardSpendings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StandardSpendingID,CalendarYear,RestaurantsAndDining,Groceries,RentOrMortgage,ElectricAndGas")] StandardSpending standardSpending)
        {
            if (ModelState.IsValid)
            {
                db.Entry(standardSpending).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(standardSpending);
        }

        // GET: StandardSpendings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StandardSpending standardSpending = db.StandardSpendings.Find(id);
            if (standardSpending == null)
            {
                return HttpNotFound();
            }
            return View(standardSpending);
        }

        // POST: StandardSpendings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StandardSpending standardSpending = db.StandardSpendings.Find(id);
            db.StandardSpendings.Remove(standardSpending);
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
