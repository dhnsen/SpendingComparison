namespace SpendingComparison.Migrations
{
    using SpendingComparison.Models;
    using SpendingComparison.Models.StatisticalSupport;
    using System.Data.Entity.Migrations;

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
                new Region() { RegionId = 1, Name = "NorthEast" },
                new Region() { RegionId = 2, Name = "MidWest" },
                new Region() { RegionId = 3, Name = "South" },
                new Region() { RegionId = 4, Name = "West" }
            );

            _context.IncomeRanges.AddOrUpdate(i => i.IncomeRangeId,
                new IncomeRange() { IncomeRangeId = 1, BottomIncomeRange = 0, TopIncomeRange = 14999 },
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
                new RegionMultiplier() { RegionMultiplierId = 1, RegionId = 1, Groceries = 1.08, RestaurantsAndDining = 1, RentOrMortgage = 1.22, Utilities = 1.15, Telephone = 1.04, Household = 1.03, HouseholdEquipment = .99, Clothing = 1.06, Vehicles = .8, Gasoline = .88, HealthCare = 1.04, Entertainment = .98, Education = 1.57 },
                new RegionMultiplier() { RegionMultiplierId = 2, RegionId = 2, Groceries = .94, RestaurantsAndDining = .94, RentOrMortgage = .83, Utilities = 1, Telephone = .96, Household = .92, HouseholdEquipment = 1.10, Clothing = .94, Vehicles = .95, Gasoline = .98, HealthCare = 1.07, Entertainment = 1.04, Education = .86 },
                new RegionMultiplier() { RegionMultiplierId = 3, RegionId = 3, Groceries = .91, RestaurantsAndDining = .93, RentOrMortgage = .85, Utilities = 1, Telephone = .98, Household = .96, HouseholdEquipment = .9, Clothing = .91, Vehicles = 1.07, Gasoline = .99, HealthCare = .95, Entertainment = .88, Education = .76 },
                new RegionMultiplier() { RegionMultiplierId = 4, RegionId = 4, Groceries = 1.14, RestaurantsAndDining = 1.19, RentOrMortgage = 1.24, Utilities = .88, Telephone = 1.04, Household = 1.12, HouseholdEquipment = 1.08, Clothing = 1.16, Vehicles = 1.09, Gasoline = 1.13, HealthCare = .99, Entertainment = 1.17, Education = 1.06 }
                );

            _context.IncomeMultipliers.AddOrUpdate(i => i.IncomeMultiplierId,
                new IncomeMultiplier() { IncomeMultiplierId = 1},
                new IncomeMultiplier() { IncomeMultiplierId = 1 },
                new IncomeMultiplier() { IncomeMultiplierId = 1 },
                new IncomeMultiplier() { IncomeMultiplierId = 1 },
                new IncomeMultiplier() { IncomeMultiplierId = 1 },
                new IncomeMultiplier() { IncomeMultiplierId = 1 },
                new IncomeMultiplier() { IncomeMultiplierId = 1 },
                new IncomeMultiplier() { IncomeMultiplierId = 1 },
                new IncomeMultiplier() { IncomeMultiplierId = 1 }

           );

            _context.SaveChanges();
        }
    }
}
