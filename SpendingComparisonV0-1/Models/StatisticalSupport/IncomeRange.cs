using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpendingComparisonV0_1.Models.StatisticalSupport
{
    public class IncomeRange
    {
        [Key]
        [Display(Name = "Income Range")]
        public int IncomeRangeID { get; set; }
        [Required]
        [Display(Name = "Bottom Income Range")]
        public decimal BottomIncomeRange { get; set; }
        [Required]
        [Display(Name = "Top Income Range")]
        public decimal TopIncomeRange { get; set; }

        public string ToString => this.BottomIncomeRange + " - " + this.TopIncomeRange;

    }
}