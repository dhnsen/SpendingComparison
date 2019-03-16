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
        public int StandardSpendingID { get; set; }
        [Required]
        [Display(Name = "Calendar Year")]
        public int CalendarYear { get; set; }


        [Required]
        [Display(Name = "Restaurants and Dining")]
        public decimal RestaurantsAndDining { get; set; }
        [Required]
        [Display(Name = "Groceries")]
        public decimal Groceries { get; set; }
        [Required]
        [Display(Name = "Rent or Mortgage")]
        public decimal RentOrMortgage { get; set; }
        [Required]
        [Display(Name = "Electric and Gas (heating)")]
        public decimal ElectricAndGas { get; set; }
    }
}