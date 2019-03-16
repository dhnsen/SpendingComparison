using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpendingComparisonV0_1.Models.SpendingModels
{
    public class CalculatorResultViewModel
    {
        // The spending categories from the user
        [Display(Name = "Restaurants and Dining")]
        public decimal RestaurantsAndDining { get; set; }
        [Display(Name = "Groceries")]
        public decimal Groceries { get; set; }
        [Display(Name = "Rent or Mortgage")]
        public decimal RentOrMortgage { get; set; }
        [Display(Name = "Electric and Gas (heating)")]
        public decimal ElectricAndGas { get; set; }

        // The numbers from the comparison spending model
        public decimal ComparisonRestaurantsAndDining { get; set; }
        public decimal ComparisonGroceries { get; set; }
        public decimal ComparisonRentOrMortgage { get; set; }
        public decimal ComparisonElectricAndGas { get; set; }

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