using Microsoft.AspNet.Identity.EntityFramework;
using SpendingComparison.Models.StatisticalSupport;
using System.Data.Entity;

namespace SpendingComparison.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Region> Regions { get; set; }
        public DbSet<RegionMultiplier> RegionMultipliers { get; set; }
        public DbSet<IncomeRange> IncomeRanges { get; set; }
        public DbSet<IncomeMultiplier> IncomeMultipliers { get; set; }
        public DbSet<StandardSpending> StandardSpendings { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}