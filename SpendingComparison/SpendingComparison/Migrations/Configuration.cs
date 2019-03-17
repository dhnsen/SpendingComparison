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
                new IncomeMultiplier() { IncomeMultiplierId = 1, IncomeRangeId = 1, Groceries = .57, RestaurantsAndDining = .44, RentOrMortgage = .5, Utilities = .61, Telephone = .48, Household = .32, HouseholdEquipment = .4, Clothing = .48, Vehicles = .33, Gasoline = .44, HealthCare = .45, Entertainment = .39, Education = .6},
                new IncomeMultiplier() { IncomeMultiplierId = 2, IncomeRangeId = 2, Groceries =  .71, RestaurantsAndDining = .50, RentOrMortgage =.64, Utilities = .8, Telephone = .65, Household = .53, HouseholdEquipment = .5, Clothing = .55, Vehicles = .50, Gasoline = .62, HealthCare = .68, Entertainment = .49, Education = .34},
                new IncomeMultiplier() { IncomeMultiplierId = 3, IncomeRangeId = 3, Groceries =  .87, RestaurantsAndDining = .62, RentOrMortgage = .71, Utilities = .91, Telephone = .88, Household = .63, HouseholdEquipment = .57, Clothing = .72, Vehicles = .78, Gasoline = .84, HealthCare = .86, Entertainment = .61, Education = .26},
                new IncomeMultiplier() { IncomeMultiplierId = 4, IncomeRangeId = 4, Groceries =  .88, RestaurantsAndDining = .82, RentOrMortgage = .8, Utilities = .95, Telephone = .92, Household = .71, HouseholdEquipment = .76, Clothing = .74, Vehicles = .77, Gasoline = .92, HealthCare = .92, Entertainment = .67, Education = .33},
                new IncomeMultiplier() { IncomeMultiplierId = 5, IncomeRangeId = 5, Groceries =  .95, RestaurantsAndDining = .98, RentOrMortgage = .91, Utilities = .99, Telephone = 1.02, Household = .82, HouseholdEquipment = .94, Clothing = .78, Vehicles = 1.04, Gasoline = 1.04, HealthCare = .96, Entertainment = .86, Education =.48 },
                new IncomeMultiplier() { IncomeMultiplierId = 6, IncomeRangeId = 6, Groceries =  1.08, RestaurantsAndDining = 1.09, RentOrMortgage = 1.09, Utilities = 1.09, Telephone = 1.21, Household = 1.01, HouseholdEquipment = 1.19, Clothing = 1.08, Vehicles = 1.1, Gasoline = 1.26, HealthCare = 1.14, Entertainment = 1.08, Education = .75},
                new IncomeMultiplier() { IncomeMultiplierId = 7, IncomeRangeId = 7, Groceries =  1.38, RestaurantsAndDining = 1.46, RentOrMortgage = 1.32, Utilities = 1.23, Telephone = 1.37, Household = 1.46, HouseholdEquipment = 1.51, Clothing = 1.51, Vehicles = 1.49, Gasoline = 1.44, HealthCare = 1.39, Entertainment = 1.46, Education = 1.17},
                new IncomeMultiplier() { IncomeMultiplierId = 8, IncomeRangeId = 8, Groceries =  1.44, RestaurantsAndDining = 1.75, RentOrMortgage = 1.85, Utilities = 1.39, Telephone = 1.53, Household = 1.94, HouseholdEquipment = 2.06, Clothing = 1.87, Vehicles = 1.78, Gasoline = 1.51, HealthCare = 1.51, Entertainment = 2.23, Education = 2.99},
                new IncomeMultiplier() { IncomeMultiplierId = 9, IncomeRangeId = 9, Groceries =  1.75, RestaurantsAndDining = 2.58, RentOrMortgage = 2.49, Utilities = 1.63, Telephone = 1.67, Household = 3.57, HouseholdEquipment = 2.46, Clothing = 2.61, Vehicles = 2.57, Gasoline = 1.6, HealthCare = 1.97, Entertainment = 2.97, Education = 5.91}

           );
            //spending data is for an entire year. dividing each figure by 12 to make them monthly
            // woot! magic numbers!
            _context.StandardSpendings.AddOrUpdate(s => s.StandardSpendingId,
                new StandardSpending() { StandardSpendingId = 1, CalendarYear = 2017, Groceries = 4363/12, RestaurantsAndDining = 3365/12, RentOrMortgage = 11895/12, Utilities = 2481/12, Telephone = 1356/12, Household = 1212/12, HouseholdEquipment = 1987/12, Clothing = 1833/12, Vehicles = 5021/12, Gasoline = 1968/12, HealthCare = 4928/12, Entertainment = 3203/12, Education = 1491/12}

                );
            _context.SaveChanges();
        }
    }
}
