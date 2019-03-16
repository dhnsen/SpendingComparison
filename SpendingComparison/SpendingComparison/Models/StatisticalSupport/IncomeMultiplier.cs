using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpendingComparison.Models.Multipliers
{
    public class IncomeMultiplier
    {
        [Key]
        public int MultiplierIncomeID { get; set; }

        [Required]
        [Display(Name = "Income Range")]
        public int IncomeRangeId { get; set; }
        [Display(Name = "Income Range")]
        public virtual IncomeRange IncomeRange { get; set; }


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