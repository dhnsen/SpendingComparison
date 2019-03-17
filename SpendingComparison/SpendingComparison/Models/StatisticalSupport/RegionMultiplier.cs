using System;
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
        public int RegionId { get; set; }
        
        public virtual Region Region { get; set; }


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