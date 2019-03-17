﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpendingComparison.Models.StatisticalSupport
{
    public class IncomeMultiplier
    {
        [Key]
        public int IncomeMultiplierId { get; set; }

        [Required]
        public int IncomeRangeId { get; set; }
        
        public virtual IncomeRange IncomeRange { get; set; }

        [Required]
        public decimal Groceries { get; set; }

        [Required]
        public decimal RestaurantsAndDining { get; set; }

        [Required]
        public decimal RentOrMortgage { get; set; }

        [Required]
        public decimal Utilities { get; set; }

        [Required]
        public decimal Telephone { get; set; }

        [Required]
        public decimal Household { get; set; }

        [Required]
        public decimal HouseholdEquipment { get; set; }

        [Required]
        public decimal Clothing { get; set; }

        [Required]
        public decimal Vehicles { get; set; }

        [Required]
        public decimal Gasoline { get; set; }

        [Required]
        public decimal HealthCare { get; set; }

        [Required]
        public decimal Entertainment { get; set; }

        [Required]
        public decimal Education { get; set; }
    }
}