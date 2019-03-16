using System.ComponentModel.DataAnnotations;

namespace SpendingComparison.Models.Multipliers
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