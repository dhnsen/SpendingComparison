﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpendingComparisonV0_1.Models.StatisticalSupport
{
    public class Region
    {
        [Key]
        [Display(Name = "Region")]
        public int RegionID { get; set; }
        [Required]
        [Display(Name = "Name of Region")]
        public string Name { get; set; }

        public string ToString => this.Name;
    }
}