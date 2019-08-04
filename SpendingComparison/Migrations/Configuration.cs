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
                new RegionMultiplier() { RegionMultiplierId = 1, RegionId = 1, Groceries = 1.08m, RestaurantsAndDining = 1, RentOrMortgage = 1.22m, Utilities = 1.15m, Telephone = 1.04m, Household = 1.03m, HouseholdEquipment = .99m, Clothing = 1.06m, Vehicles = .8m, Gasoline = .88m, HealthCare = 1.04m, Entertainment = .98m, Education = 1.57m },
                new RegionMultiplier() { RegionMultiplierId = 2, RegionId = 2, Groceries = .94m, RestaurantsAndDining = .94m, RentOrMortgage = .83m, Utilities = 1, Telephone = .96m, Household = .92m, HouseholdEquipment = 1.10m, Clothing = .94m, Vehicles = .95m, Gasoline = .98m, HealthCare = 1.07m, Entertainment = 1.04m, Education = .86m },
                new RegionMultiplier() { RegionMultiplierId = 3, RegionId = 3, Groceries = .91m, RestaurantsAndDining = .93m, RentOrMortgage = .85m, Utilities = 1, Telephone = .98m, Household = .96m, HouseholdEquipment = .9m, Clothing = .91m, Vehicles = 1.07m, Gasoline = .99m, HealthCare = .95m, Entertainment = .88m, Education = .76m },
                new RegionMultiplier() { RegionMultiplierId = 4, RegionId = 4, Groceries = 1.14m, RestaurantsAndDining = 1.19m, RentOrMortgage = 1.24m, Utilities = .88m, Telephone = 1.04m, Household = 1.12m, HouseholdEquipment = 1.08m, Clothing = 1.16m, Vehicles = 1.09m, Gasoline = 1.13m, HealthCare = .99m, Entertainment = 1.17m, Education = 1.06m }
                );

            _context.IncomeMultipliers.AddOrUpdate(i => i.IncomeMultiplierId,
                new IncomeMultiplier() { IncomeMultiplierId = 1, IncomeRangeId = 1, Groceries = .57m, RestaurantsAndDining = .44m, RentOrMortgage = .5m, Utilities = .61m, Telephone = .48m, Household = .32m, HouseholdEquipment = .4m, Clothing = .48m, Vehicles = .33m, Gasoline = .44m, HealthCare = .45m, Entertainment = .39m, Education = .6m},
                new IncomeMultiplier() { IncomeMultiplierId = 2, IncomeRangeId = 2, Groceries =  .71m, RestaurantsAndDining = .50m, RentOrMortgage =.64m, Utilities = .8m, Telephone = .65m, Household = .53m, HouseholdEquipment = .5m, Clothing = .55m, Vehicles = .50m, Gasoline = .62m, HealthCare = .68m, Entertainment = .49m, Education = .34m},
                new IncomeMultiplier() { IncomeMultiplierId = 3, IncomeRangeId = 3, Groceries =  .87m, RestaurantsAndDining = .62m, RentOrMortgage = .71m, Utilities = .91m, Telephone = .88m, Household = .63m, HouseholdEquipment = .57m, Clothing = .72m, Vehicles = .78m, Gasoline = .84m, HealthCare = .86m, Entertainment = .61m, Education = .26m},
                new IncomeMultiplier() { IncomeMultiplierId = 4, IncomeRangeId = 4, Groceries =  .88m, RestaurantsAndDining = .82m, RentOrMortgage = .8m, Utilities = .95m, Telephone = .92m, Household = .71m, HouseholdEquipment = .76m, Clothing = .74m, Vehicles = .77m, Gasoline = .92m, HealthCare = .92m, Entertainment = .67m, Education = .33m},
                new IncomeMultiplier() { IncomeMultiplierId = 5, IncomeRangeId = 5, Groceries =  .95m, RestaurantsAndDining = .98m, RentOrMortgage = .91m, Utilities = .99m, Telephone = 1.02m, Household = .82m, HouseholdEquipment = .94m, Clothing = .78m, Vehicles = 1.04m, Gasoline = 1.04m, HealthCare = .96m, Entertainment = .86m, Education =.48m },
                new IncomeMultiplier() { IncomeMultiplierId = 6, IncomeRangeId = 6, Groceries =  1.08m, RestaurantsAndDining = 1.09m, RentOrMortgage = 1.09m, Utilities = 1.09m, Telephone = 1.21m, Household = 1.01m, HouseholdEquipment = 1.19m, Clothing = 1.08m, Vehicles = 1.1m, Gasoline = 1.26m, HealthCare = 1.14m, Entertainment = 1.08m, Education = .75m},
                new IncomeMultiplier() { IncomeMultiplierId = 7, IncomeRangeId = 7, Groceries =  1.38m, RestaurantsAndDining = 1.46m, RentOrMortgage = 1.32m, Utilities = 1.23m, Telephone = 1.37m, Household = 1.46m, HouseholdEquipment = 1.51m, Clothing = 1.51m, Vehicles = 1.49m, Gasoline = 1.44m, HealthCare = 1.39m, Entertainment = 1.46m, Education = 1.17m},
                new IncomeMultiplier() { IncomeMultiplierId = 8, IncomeRangeId = 8, Groceries =  1.44m, RestaurantsAndDining = 1.75m, RentOrMortgage = 1.85m, Utilities = 1.39m, Telephone = 1.53m, Household = 1.94m, HouseholdEquipment = 2.06m, Clothing = 1.87m, Vehicles = 1.78m, Gasoline = 1.51m, HealthCare = 1.51m, Entertainment = 2.23m, Education = 2.99m},
                new IncomeMultiplier() { IncomeMultiplierId = 9, IncomeRangeId = 9, Groceries =  1.75m, RestaurantsAndDining = 2.58m, RentOrMortgage = 2.49m, Utilities = 1.63m, Telephone = 1.67m, Household = 3.57m, HouseholdEquipment = 2.46m, Clothing = 2.61m, Vehicles = 2.57m, Gasoline = 1.6m, HealthCare = 1.97m, Entertainment = 2.97m, Education = 5.91m}

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
