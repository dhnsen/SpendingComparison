using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpendingComparison.Models.StatisticalSupport
{
    public class Region
    {
        [Key]
        [Display(Name = "Region")]
        public int RegionId { get; set; }
        [Required]
        [Display(Name = "Name of Region")]
        public string Name { get; set; }

        public string ToString => this.Name;
    }
}