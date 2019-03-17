using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SpendingComparison.Models;
using SpendingComparison.Models.StatisticalSupport;
using SpendingComparison.Models.ViewModels;

namespace SpendingComparison.Controllers
{
    public class CalculatorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

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
                calculatorResultViewModel.Groceries = calculatorViewModel.Groceries;
                calculatorResultViewModel.RestaurantsAndDining = calculatorViewModel.RestaurantsAndDining;
                calculatorResultViewModel.RentOrMortgage = calculatorViewModel.RentOrMortgage;
                calculatorResultViewModel.Utilities = calculatorViewModel.Utilities;
                calculatorResultViewModel.Telephone = calculatorViewModel.Telephone;
                calculatorResultViewModel.Household = calculatorViewModel.Household;
                calculatorResultViewModel.HouseholdEquipment = calculatorViewModel.HouseholdEquipment;
                calculatorResultViewModel.Clothing = calculatorViewModel.Clothing;
                calculatorResultViewModel.Vehicles = calculatorViewModel.Vehicles;
                calculatorResultViewModel.Gasoline = calculatorViewModel.Gasoline;
                calculatorResultViewModel.HealthCare = calculatorViewModel.HealthCare;
                calculatorResultViewModel.Entertainment = calculatorViewModel.Entertainment;
                calculatorResultViewModel.Education = calculatorViewModel.Education;

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
                int mostRecentYear = 2017;
                StandardSpending standardSpending = db.StandardSpendings.Where(s => s.CalendarYear == mostRecentYear).FirstOrDefault();

                // initialize the comparison variables in the view model using the multipliers
                calculatorResultViewModel.ComparisonGroceries = standardSpending.Groceries * regionMultiplier.Groceries * incomeMultiplier.Groceries;
                calculatorResultViewModel.ComparisonRestaurantsAndDining = standardSpending.RestaurantsAndDining * regionMultiplier.RestaurantsAndDining * incomeMultiplier.RestaurantsAndDining;
                calculatorResultViewModel.ComparisonRentOrMortgage = standardSpending.RentOrMortgage * regionMultiplier.RentOrMortgage * incomeMultiplier.RentOrMortgage;
                calculatorResultViewModel.ComparisonUtilities = standardSpending.Utilities * regionMultiplier.Utilities * incomeMultiplier.Utilities;
                calculatorResultViewModel.ComparisonTelephone = standardSpending.Telephone * regionMultiplier.Telephone * incomeMultiplier.Telephone;
                calculatorResultViewModel.ComparisonHousehold = standardSpending.Household * regionMultiplier.Household * incomeMultiplier.Household;
                calculatorResultViewModel.ComparisonHouseholdEquipment = standardSpending.HouseholdEquipment * regionMultiplier.HouseholdEquipment * incomeMultiplier.HouseholdEquipment;
                calculatorResultViewModel.ComparisonClothing = standardSpending.Clothing * regionMultiplier.Clothing * incomeMultiplier.Clothing;
                calculatorResultViewModel.ComparisonVehicles = standardSpending.Vehicles * regionMultiplier.Vehicles * incomeMultiplier.Vehicles;
                calculatorResultViewModel.ComparisonGasoline = standardSpending.Gasoline * regionMultiplier.Gasoline * incomeMultiplier.Gasoline;
                calculatorResultViewModel.ComparisonHealthCare = standardSpending.HealthCare * regionMultiplier.HealthCare * incomeMultiplier.HealthCare;
                calculatorResultViewModel.ComparisonEntertainment = standardSpending.Entertainment * regionMultiplier.Entertainment * incomeMultiplier.Entertainment;
                calculatorResultViewModel.ComparisonEducation = standardSpending.Education * regionMultiplier.Education * incomeMultiplier.Education;

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
