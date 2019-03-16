using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SpendingComparisonV0_1.Models
{
    public class StatisticsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public StatisticsContext() : base("name=StatisticsContext")
        {
        }

        public System.Data.Entity.DbSet<SpendingComparisonV0_1.Models.StatisticalSupport.Region> Regions { get; set; }

        public System.Data.Entity.DbSet<SpendingComparisonV0_1.Models.StatisticalSupport.IncomeRange> IncomeRanges { get; set; }

        public System.Data.Entity.DbSet<SpendingComparisonV0_1.Models.Multipliers.IncomeMultiplier> IncomeMultipliers { get; set; }

        public System.Data.Entity.DbSet<SpendingComparisonV0_1.Models.Multipliers.RegionMultiplier> RegionMultipliers { get; set; }

        public System.Data.Entity.DbSet<SpendingComparisonV0_1.Models.SpendingModels.StandardSpending> StandardSpendings { get; set; }
    }
}
