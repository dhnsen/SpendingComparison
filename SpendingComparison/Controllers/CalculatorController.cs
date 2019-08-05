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
            ViewBag.IncomeRangeId = new SelectList(db.IncomeRanges, "IncomeRangeId", "ToString");
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "ToString");
            return View();
        }

        // POST: Calculator
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "IncomeRangeId,RegionId,RestaurantsAndDining," +
            "Groceries,RentOrMortgage,Utilities,Telephone,Household,HouseholdEquipment,Clothing," +
            "Vehicles,Gasoline,HealthCare,Entertainment,Education")] CalculatorViewModel calculatorViewModel)
        {
            
            Session["calculatorViewModel"] = calculatorViewModel;
            return RedirectToAction("CalculatorResult");
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
                // I felt like this should be a method in a model (information expert)
                // 
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
                if (calculatorViewModel.Groceries < calculatorResultViewModel.ComparisonGroceries)
                {
                    calculatorResultViewModel.GroceriesGood = true;
                }
                else
                {
                    calculatorResultViewModel.GroceriesGood = false;
                }
                
                if (calculatorViewModel.RestaurantsAndDining < calculatorResultViewModel.ComparisonRestaurantsAndDining)
                {
                    calculatorResultViewModel.RestaurantsAndDiningGood = true;
                }
                else
                {
                    calculatorResultViewModel.RestaurantsAndDiningGood = false;
                }

                if (calculatorViewModel.RentOrMortgage < calculatorResultViewModel.ComparisonRentOrMortgage)
                {
                    calculatorResultViewModel.RentOrMortgageGood = true;
                }
                else
                {
                    calculatorResultViewModel.RentOrMortgageGood = false;
                }

                if (calculatorViewModel.Utilities < calculatorResultViewModel.ComparisonUtilities)
                {
                    calculatorResultViewModel.UtilitiesGood = true;
                }
                else
                {
                    calculatorResultViewModel.UtilitiesGood = false;
                }

                if (calculatorViewModel.Telephone < calculatorResultViewModel.ComparisonTelephone)
                {
                    calculatorResultViewModel.TelephoneGood = true;
                }
                else
                {
                    calculatorResultViewModel.TelephoneGood = false;
                }

                if (calculatorViewModel.Household < calculatorResultViewModel.ComparisonHousehold)
                {
                    calculatorResultViewModel.HouseholdGood = true;
                }
                else
                {
                    calculatorResultViewModel.HouseholdGood = false;
                }

                if (calculatorViewModel.HouseholdEquipment < calculatorResultViewModel.ComparisonHouseholdEquipment)
                {
                    calculatorResultViewModel.HouseholdEquipmentGood = true;
                }
                else
                {
                    calculatorResultViewModel.HouseholdEquipmentGood = false;
                }

                if (calculatorViewModel.Clothing < calculatorResultViewModel.ComparisonClothing)
                {
                    calculatorResultViewModel.ClothingGood = true;
                }
                else
                {
                    calculatorResultViewModel.ClothingGood = false;
                }

                if (calculatorViewModel.Vehicles < calculatorResultViewModel.ComparisonVehicles)
                {
                    calculatorResultViewModel.VehiclesGood = true;
                }
                else
                {
                    calculatorResultViewModel.VehiclesGood = false;
                }

                if (calculatorViewModel.Gasoline < calculatorResultViewModel.ComparisonGasoline)
                {
                    calculatorResultViewModel.GasolineGood = true;
                }
                else
                {
                    calculatorResultViewModel.GasolineGood = false;
                }

                if (calculatorViewModel.HealthCare < calculatorResultViewModel.ComparisonHealthCare)
                {
                    calculatorResultViewModel.HealthCareGood = true;
                }
                else
                {
                    calculatorResultViewModel.HealthCareGood = false;
                }

                if (calculatorViewModel.Entertainment < calculatorResultViewModel.ComparisonEntertainment)
                {
                    calculatorResultViewModel.EntertainmentGood = true;
                }
                else
                {
                    calculatorResultViewModel.EntertainmentGood = false;
                }

                if (calculatorViewModel.Education < calculatorResultViewModel.ComparisonEducation)
                {
                    calculatorResultViewModel.EducationGood = true;
                }
                else
                {
                    calculatorResultViewModel.EducationGood = false;
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
