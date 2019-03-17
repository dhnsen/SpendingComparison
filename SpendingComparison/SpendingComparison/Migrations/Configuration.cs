namespace SpendingComparison.Migrations
{
    using SpendingComparison.Models;
    using SpendingComparison.Models.StatisticalSupport;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SpendingComparison.Models.ApplicationDbContext>
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SpendingComparison.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            _context.Regions.AddOrUpdate(r => r.RegionId,
                new Region() { RegionId=1, Name = "NorthEast"},
                new Region() { RegionId = 2, Name = "MidWest" },
                new Region() { RegionId = 3, Name = "South" },
                new Region() { RegionId = 4, Name = "West" }
                );
            _context.IncomeRanges.AddOrUpdate(i => i.IncomeRangeId,
                new IncomeRange() { IncomeRangeId=1, BottomIncomeRange=0, TopIncomeRange=14999},
                new IncomeRange() { IncomeRangeId = 2, BottomIncomeRange = 15000, TopIncomeRange = 29999 },
                new IncomeRange() { IncomeRangeId = 3, BottomIncomeRange = 30000, TopIncomeRange = 39999 },
                new IncomeRange() { IncomeRangeId = 4, BottomIncomeRange = 40000, TopIncomeRange = 49999 },
                new IncomeRange() { IncomeRangeId = 5, BottomIncomeRange = 50000, TopIncomeRange = 69999 },
                new IncomeRange() { IncomeRangeId = 6, BottomIncomeRange = 70000, TopIncomeRange = 99999 },
                new IncomeRange() { IncomeRangeId = 7, BottomIncomeRange = 100000, TopIncomeRange = 149999 },
                new IncomeRange() { IncomeRangeId = 8, BottomIncomeRange = 150000, TopIncomeRange = 199999 },
                new IncomeRange() { IncomeRangeId = 9, BottomIncomeRange = 200000, TopIncomeRange = 1000000 }
            );
            _context.RegionMultipliers.AddOrUpdate(r => r.RegionMultiplierId,
                new RegionMultiplier() { RegionMultiplierId = 1, RegionId = 1, Groceries = 1.08, RestaurantsAndDining = 1, RentOrMortgage = 1.22},
                new RegionMultiplier() { RegionMultiplierId = 2, RegionId = 2, Groceries = .94, RestaurantsAndDining = .94, RentOrMortgage = .83},
                new RegionMultiplier() { RegionMultiplierId = 3, RegionId = 3, Groceries = .91, RestaurantsAndDining = .93, RentOrMortgage = .85},
                new RegionMultiplier() { RegionMultiplierId = 4, RegionId = 4, Groceries = 1.14, RestaurantsAndDining = 1.19, RentOrMortgage = 1.24}
                );
            _context.SaveChanges();
        }
    }
}
