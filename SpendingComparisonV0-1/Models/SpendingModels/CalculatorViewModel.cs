﻿using SpendingComparisonV0_1.Models.StatisticalSupport;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpendingComparisonV0_1.Models.SpendingModels
{
    public class CalculatorViewModel
    {
        [Required]
        [Display(Name = "Income Range")]
        public int IncomeRangeId { get; set; }
        [Display(Name = "Income Range")]
        public virtual IncomeRange IncomeRange { get; set; }
        [Required]
        [Display(Name = "Region")]
        public int RegionId { get; set; }
        [Display(Name = "Region")]
        public virtual Region Region { get; set; }


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