using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpendingComparison.Models.StatisticalSupport
{
    public class IncomeMultiplier
    {
        [Key]
        public int MultiplierIncomeId { get; set; }

        [Required]
        public int IncomeRangeId { get; set; }
        
        public virtual IncomeRange IncomeRange { get; set; }

        [Required]
        public double Groceries { get; set; }

        [Required]
        public double RestaurantsAndDining { get; set; }

        [Required]
        public double RentOrMortgage { get; set; }

        [Required]
        public double Utilities { get; set; }

        [Required]
        public double Telephone { get; set; }

        [Required]
        public double Household { get; set; }

        [Required]
        public double HouseholdEquipment { get; set; }

        [Required]
        public double Clothing { get; set; }

        [Required]
        public double Vehicles { get; set; }

        [Required]
        public double Gasoline { get; set; }

        [Required]
        public double HealthCare { get; set; }

        [Required]
        public double Entertainment { get; set; }

        [Required]
        public double Education { get; set; }
    }
}