using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpendingComparison.Models
{
    public class StandardSpending
    {
        [Key]
        public int StandardSpendingId { get; set; }

        [Required]
        [Display(Name = "Calendar Year")]
        public int CalendarYear { get; set; }

        
        [Display(Name = "Groceries")]
        public decimal Groceries { get; set; }
        
        [Display(Name = "Restaurants and Dining")]
        public decimal RestaurantsAndDining { get; set; }
        
        [Display(Name = "Rent or Mortgage")]
        public decimal RentOrMortgage { get; set; }
        
        [Display(Name = "Utilities (e.g. electric, water)")]
        public decimal Utilities { get; set; }

        [Display(Name = "Phone Service")]
        public decimal Telephone { get; set; }

        [Display(Name = "Household Supplies (e.g. toilet paper, dish soap)")]
        public decimal Household { get; set; }

        [Display(Name = "Furniture and Appliances")]
        public decimal HouseholdEquipment { get; set; }

        [Display(Name = "Clothing")]
        public decimal Clothing { get; set; }

        [Display(Name = "Vehicles (e.g. loan payments, insurance)")]
        public decimal Vehicles { get; set; }

        [Display(Name = "Gasoline (or other fuel)")]
        public decimal Gasoline { get; set; }

        [Display(Name = "Health Care (insurance, prescriptions and copays")]
        public decimal HealthCare { get; set; }

        [Display(Name = "Entertainment (e.g. video games, concert tickets")]
        public decimal Entertainment { get; set; }

        [Display(Name = "Education (e.g. student loans)")]
        public decimal Education { get; set; }
    }
}