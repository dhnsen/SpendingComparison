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
            _context.IncomeRanges.AddOrUpdate(i => i.IncomeRangeId

            );
            _context.SaveChanges();
        }
    }
}
