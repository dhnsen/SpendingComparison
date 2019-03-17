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
        public decimal Groceries { get; set; }

        [Display(Name = "Restaurants and Dining")]
        public decimal RestaurantsAndDining { get; set; }

        [Display(Name = "Rent or Mortgage")]
        public decimal RentOrMortgage { get; set; }

        [Display(Name = "Utilities")]
        public decimal Utilities { get; set; }

        [Display(Name = "Phone Service")]
        public decimal Telephone { get; set; }

        [Display(Name = "Household Supplies")]
        public decimal Household { get; set; }

        [Display(Name = "Furniture and Appliances")]
        public decimal HouseholdEquipment { get; set; }

        [Display(Name = "Clothing")]
        public decimal Clothing { get; set; }

        [Display(Name = "Vehicles")]
        public decimal Vehicles { get; set; }

        [Display(Name = "Gasoline")]
        public decimal Gasoline { get; set; }

        [Display(Name = "Health Care")]
        public decimal HealthCare { get; set; }

        [Display(Name = "Entertainment")]
        public decimal Entertainment { get; set; }

        [Display(Name = "Education")]
        public decimal Education { get; set; }

        // The numbers from the comparison spending model
        public decimal ComparisonGroceries { get; set; }
        public decimal ComparisonRestaurantsAndDining { get; set; }
        public decimal ComparisonRentOrMortgage { get; set; }
        public decimal ComparisonUtilities { get; set; }
        public decimal ComparisonTelephone { get; set; }
        public decimal ComparisonHousehold { get; set; }
        public decimal ComparisonHouseholdEquipment { get; set; }
        public decimal ComparisonClothing { get; set; }
        public decimal ComparisonVehicles { get; set; }
        public decimal ComparisonGasoline { get; set; }
        public decimal ComparisonHealthCare { get; set; }
        public decimal ComparisonEntertainment { get; set; }
        public decimal ComparisonEducation { get; set; }

        // The results of the comparison
        public bool GroceriesGood { get; set; }
        public bool RestaurantsAndDiningGood { get; set; }
        public bool RentOrMortgageGood { get; set; }
        public bool UtilitiesGood { get; set; }
        public bool TelephoneGood { get; set; }
        public bool HouseholdGood { get; set; }
        public bool HouseholdEquipmentGood { get; set; }
        public bool ClothingGood { get; set; }
        public bool VehiclesGood { get; set; }
        public bool GasolineGood { get; set; }
        public bool HealthCareGood { get; set; }
        public bool EntertainmentGood { get; set; }
        public bool EducationGood { get; set; }

        // Informational messages
        
        public string GroceriesStatus
        {
            get
            {
                return this.GroceriesGood ? "Good" : "Needs Improvement";
            }
        }
        public string RestaurantsAndDiningStatus
        {
            get
            {
                return this.RestaurantsAndDiningGood ? "Good" : "Needs Improvement";
            }
        }
        public string RentOrMortgageStatus
        {
            get
            {
                return this.RentOrMortgageGood ? "Good" : "Needs Improvement";
            }
        }
        public string UtilitiesStatus
        {
            get
            {
                return this.UtilitiesGood ? "Good" : "Needs Improvement";
            }
        }
        public string TelephoneStatus
        {
            get
            {
                return this.TelephoneGood ? "Good" : "Needs Improvement";
            }
        }
        public string HouseholdStatus
        {
            get
            {
                return this.HouseholdGood ? "Good" : "Needs Improvement";
            }
        }
        public string HouseholdEquipmentStatus
        {
            get
            {
                return this.HouseholdEquipmentGood ? "Good" : "Needs Improvement";
            }
        }
        public string ClothingStatus
        {
            get
            {
                return this.ClothingGood ? "Good" : "Needs Improvement";
            }
        }
        public string VehiclesStatus
        {
            get
            {
                return this.VehiclesGood ? "Good" : "Needs Improvement";
            }
        }
        public string GasolineStatus
        {
            get
            {
                return this.GasolineGood ? "Good" : "Needs Improvement";
            }
        }
        public string HealthCareStatus
        {
            get
            {
                return this.HealthCareGood ? "Good" : "Needs Improvement";
            }
        }
        public string EntertainmentStatus
        {
            get
            {
                return this.EntertainmentGood ? "Good" : "Needs Improvement";
            }
        }
        public string EducationStatus
        {
            get
            {
                return this.EducationGood ? "Good" : "Needs Improvement";
            }
        }

    }
}