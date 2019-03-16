﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SpendingComparison.Models.StatisticalSupport
{
    public class RegionMultiplier
    {
        [Key]
        public int RegionMultiplierId { get; set; }
        [Required]
        [Display(Name = "Region")]
        [ForeignKey("Region")]
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