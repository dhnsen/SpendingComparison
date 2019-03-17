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
        public double Groceries { get; set; }
        
        [Display(Name = "Restaurants and Dining")]
        public double RestaurantsAndDining { get; set; }
        
        [Display(Name = "Rent or Mortgage")]
        public double RentOrMortgage { get; set; }
        
        [Display(Name = "Utilities (e.g. electric, water)")]
        public double Utilities { get; set; }

        [Display(Name = "Phone Service")]
        public double Telephone { get; set; }

        [Display(Name = "Household Supplies (e.g. toilet paper, dish soap)")]
        public double Household { get; set; }

        [Display(Name = "Furniture and Appliances")]
        public double HouseholdEquipment { get; set; }

        [Display(Name = "Clothing")]
        public double Clothing { get; set; }

        [Display(Name = "Vehicles (e.g. loan payments, insurance)")]
        public double Vehicles { get; set; }

        [Display(Name = "Gasoline (or other fuel)")]
        public double Gasoline { get; set; }

        [Display(Name = "Health Care (insurance, prescriptions and copays")]
        public double HealthCare { get; set; }

        [Display(Name = "Entertainment (e.g. video games, concert tickets")]
        public double Entertainment { get; set; }

        [Display(Name = "Education (e.g. student loans)")]
        public double Education { get; set; }
    }
}