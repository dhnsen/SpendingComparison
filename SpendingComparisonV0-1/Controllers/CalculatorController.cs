using SpendingComparisonV0_1.Models;
using SpendingComparisonV0_1.Models.Multipliers;
using SpendingComparisonV0_1.Models.SpendingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SpendingComparisonV0_1.Controllers
{
    public class CalculatorController : Controller
    {
        private StatisticsContext db = new StatisticsContext();

        //GET: Calculator
        public ActionResult Index()
        {
            ViewBag.IncomeRangeId = new SelectList(db.IncomeRanges, "IncomeRangeID", "ToString");
            ViewBag.RegionId = new SelectList(db.Regions, "RegionID", "ToString");
            return View();
        }

        // POST: Calculator
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "IncomeRangeID, RegionID,RestaurantsAndDining,Groceries,RentOrMortgage,ElectricAndGas")] CalculatorViewModel calculatorViewModel)
        {
            if (ModelState.IsValid)
            {
                Session["calculatorViewModel"] = calculatorViewModel;
                return RedirectToAction("CalculatorResult");
            }

            return View(calculatorViewModel);
        }

        // GET
        public ActionResult CalculatorResult()
        {
            if (Session["calculatorViewModel"] != null)
            {
                // create the view model to be passed to the view
                CalculatorResultViewModel calculatorResultViewModel = new CalculatorResultViewModel();

                // retrieve the model submitted by the form
                // I set this as a session variable in case the user navigates away accidentally
                CalculatorViewModel calculatorViewModel = (CalculatorViewModel)Session["calculatorViewModel"];

                // initialize data from the form into the result view model
                calculatorResultViewModel.ElectricAndGas = calculatorViewModel.ElectricAndGas;
                calculatorResultViewModel.Groceries = calculatorViewModel.Groceries;
                calculatorResultViewModel.RentOrMortgage = calculatorViewModel.RentOrMortgage;
                calculatorResultViewModel.RestaurantsAndDining = calculatorViewModel.RestaurantsAndDining;

                // retrieve the income multiplier for the user's income range
                int incomeRangeIdFromForm = calculatorViewModel.IncomeRangeId;
                var incomeMultipliers = from i in db.IncomeMultipliers
                                        where i.IncomeRangeId.Equals(incomeRangeIdFromForm)
                                        select i;
                IncomeMultiplier incomeMultiplier = incomeMultipliers.Where(i => i.IncomeRangeId == incomeRangeIdFromForm).First();

                // retrieve the region multiplier for the user's region
                int regionIdFromForm = calculatorViewModel.RegionId;
                var regionMultipliers = from r in db.RegionMultipliers
                                        where r.RegionId.Equals(regionIdFromForm)
                                        select r;
                RegionMultiplier regionMultiplier = regionMultipliers.Where(r => r.RegionId == regionIdFromForm).First();

                // get the current standard spending model
                int mostRecentYear = 2016;
                StandardSpending standardSpending = db.StandardSpendings.Where(s => s.CalendarYear == mostRecentYear).FirstOrDefault();

                // initialize the comparison variables in the view model using the multipliers
                calculatorResultViewModel.ComparisonElectricAndGas = standardSpending.ElectricAndGas * regionMultiplier.ElectricAndGas * incomeMultiplier.ElectricAndGas;
                calculatorResultViewModel.ComparisonGroceries = standardSpending.Groceries * regionMultiplier.Groceries * incomeMultiplier.Groceries;
                calculatorResultViewModel.ComparisonRentOrMortgage = standardSpending.RentOrMortgage * regionMultiplier.RentOrMortgage * incomeMultiplier.RentOrMortgage;
                calculatorResultViewModel.ComparisonRestaurantsAndDining = standardSpending.RestaurantsAndDining * regionMultiplier.RestaurantsAndDining * incomeMultiplier.RestaurantsAndDining;

                // initialize the result variables in the view model
                if (calculatorViewModel.ElectricAndGas < calculatorResultViewModel.ComparisonElectricAndGas)
                {
                    calculatorResultViewModel.ElectricAndGasGood = true;
                }
                else
                {
                    calculatorResultViewModel.ElectricAndGasGood = false;
                }

                if (calculatorViewModel.Groceries < calculatorResultViewModel.ComparisonGroceries)
                {
                    calculatorResultViewModel.GroceriesGood = true;
                }
                else
                {
                    calculatorResultViewModel.GroceriesGood = false;
                }

                if (calculatorViewModel.RentOrMortgage < calculatorResultViewModel.ComparisonRentOrMortgage)
                {
                    calculatorResultViewModel.RentOrMortgageGood = true;
                }
                else
                {
                    calculatorResultViewModel.RentOrMortgageGood = false;
                }

                if (calculatorViewModel.RestaurantsAndDining < calculatorResultViewModel.ComparisonRestaurantsAndDining)
                {
                    calculatorResultViewModel.RestaurantsAndDiningGood = true;
                }
                else
                {
                    calculatorResultViewModel.RestaurantsAndDiningGood = false;
                }

                // return the view with the view model
                return View(calculatorResultViewModel);
            }
            // otherwise just go back to index (maybe we'll create an error page later)
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}