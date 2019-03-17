using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpendingComparison.Models.ViewModels
{
    public class CalculatorResultViewModel
    {
        // The spending categories from the user
        [Display(Name = "Groceries")]
        public double Groceries { get; set; }

        [Display(Name = "Restaurants and Dining")]
        public double RestaurantsAndDining { get; set; }

        [Display(Name = "Rent or Mortgage")]
        public double RentOrMortgage { get; set; }

        [Display(Name = "Utilities")]
        public double Utilities { get; set; }

        [Display(Name = "Phone Service")]
        public double Telephone { get; set; }

        [Display(Name = "Household Supplies")]
        public double Household { get; set; }

        [Display(Name = "Furniture and Appliances")]
        public double HouseholdEquipment { get; set; }

        [Display(Name = "Clothing")]
        public double Clothing { get; set; }

        [Display(Name = "Vehicles")]
        public double Vehicles { get; set; }

        [Display(Name = "Gasoline")]
        public double Gasoline { get; set; }

        [Display(Name = "Health Care")]
        public double HealthCare { get; set; }

        [Display(Name = "Entertainment")]
        public double Entertainment { get; set; }

        [Display(Name = "Education")]
        public double Education { get; set; }

        // The numbers from the comparison spending model
        public double ComparisonGroceries { get; set; }
        public double ComparisonRestaurantsAndDining { get; set; }
        public double ComparisonRentOrMortgage { get; set; }
        public double ComparisonUtilities { get; set; }
        public double ComparisonTelephone { get; set; }
        public double ComparisonHousehold { get; set; }
        public double ComparisonHouseholdEquipment { get; set; }
        public double ComparisonClothing { get; set; }
        public double ComparisonVehicles { get; set; }
        public double ComparisonGasoline { get; set; }
        public double ComparisonHealthCare { get; set; }
        public double ComparisonEntertainment { get; set; }
        public double ComparisonEducation { get; set; }

        // The results of the comparison
        public bool RestaurantsAndDiningGood { get; set; }
        public bool GroceriesGood { get; set; }
        public bool RentOrMortgageGood { get; set; }
        public bool ElectricAndGasGood { get; set; }

        // Informational messages
        public string RestaurantsAndDiningStatus
        {
            get
            {
                return this.RestaurantsAndDiningGood ? "Good" : "Needs Improvement";
            }
        }
        public string GroceriesStatus
        {
            get
            {
                return this.GroceriesGood ? "Good" : "Needs Improvement";
            }
        }
        public string RentOrMortgageStatus
        {
            get
            {
                return this.RentOrMortgageGood ? "Good" : "Needs Improvement";
            }
        }
        public string ElectricAndGasStatus
        {
            get
            {
                return this.ElectricAndGasGood ? "Good" : "Needs Improvement";
            }
        }

    }
}