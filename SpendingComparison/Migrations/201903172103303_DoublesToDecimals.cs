namespace SpendingComparison.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoublesToDecimals : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.IncomeMultipliers", "Groceries", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.IncomeMultipliers", "RestaurantsAndDining", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.IncomeMultipliers", "RentOrMortgage", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.IncomeMultipliers", "Utilities", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.IncomeMultipliers", "Telephone", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.IncomeMultipliers", "Household", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.IncomeMultipliers", "HouseholdEquipment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.IncomeMultipliers", "Clothing", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.IncomeMultipliers", "Vehicles", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.IncomeMultipliers", "Gasoline", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.IncomeMultipliers", "HealthCare", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.IncomeMultipliers", "Entertainment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.IncomeMultipliers", "Education", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RegionMultipliers", "Groceries", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RegionMultipliers", "RestaurantsAndDining", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RegionMultipliers", "RentOrMortgage", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RegionMultipliers", "Utilities", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RegionMultipliers", "Telephone", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RegionMultipliers", "Household", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RegionMultipliers", "HouseholdEquipment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RegionMultipliers", "Clothing", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RegionMultipliers", "Vehicles", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RegionMultipliers", "Gasoline", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RegionMultipliers", "HealthCare", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RegionMultipliers", "Entertainment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RegionMultipliers", "Education", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StandardSpendings", "Groceries", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StandardSpendings", "RestaurantsAndDining", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StandardSpendings", "RentOrMortgage", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StandardSpendings", "Utilities", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StandardSpendings", "Telephone", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StandardSpendings", "Household", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StandardSpendings", "HouseholdEquipment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StandardSpendings", "Clothing", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StandardSpendings", "Vehicles", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StandardSpendings", "Gasoline", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StandardSpendings", "HealthCare", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StandardSpendings", "Entertainment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StandardSpendings", "Education", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StandardSpendings", "Education", c => c.Double(nullable: false));
            AlterColumn("dbo.StandardSpendings", "Entertainment", c => c.Double(nullable: false));
            AlterColumn("dbo.StandardSpendings", "HealthCare", c => c.Double(nullable: false));
            AlterColumn("dbo.StandardSpendings", "Gasoline", c => c.Double(nullable: false));
            AlterColumn("dbo.StandardSpendings", "Vehicles", c => c.Double(nullable: false));
            AlterColumn("dbo.StandardSpendings", "Clothing", c => c.Double(nullable: false));
            AlterColumn("dbo.StandardSpendings", "HouseholdEquipment", c => c.Double(nullable: false));
            AlterColumn("dbo.StandardSpendings", "Household", c => c.Double(nullable: false));
            AlterColumn("dbo.StandardSpendings", "Telephone", c => c.Double(nullable: false));
            AlterColumn("dbo.StandardSpendings", "Utilities", c => c.Double(nullable: false));
            AlterColumn("dbo.StandardSpendings", "RentOrMortgage", c => c.Double(nullable: false));
            AlterColumn("dbo.StandardSpendings", "RestaurantsAndDining", c => c.Double(nullable: false));
            AlterColumn("dbo.StandardSpendings", "Groceries", c => c.Double(nullable: false));
            AlterColumn("dbo.RegionMultipliers", "Education", c => c.Double(nullable: false));
            AlterColumn("dbo.RegionMultipliers", "Entertainment", c => c.Double(nullable: false));
            AlterColumn("dbo.RegionMultipliers", "HealthCare", c => c.Double(nullable: false));
            AlterColumn("dbo.RegionMultipliers", "Gasoline", c => c.Double(nullable: false));
            AlterColumn("dbo.RegionMultipliers", "Vehicles", c => c.Double(nullable: false));
            AlterColumn("dbo.RegionMultipliers", "Clothing", c => c.Double(nullable: false));
            AlterColumn("dbo.RegionMultipliers", "HouseholdEquipment", c => c.Double(nullable: false));
            AlterColumn("dbo.RegionMultipliers", "Household", c => c.Double(nullable: false));
            AlterColumn("dbo.RegionMultipliers", "Telephone", c => c.Double(nullable: false));
            AlterColumn("dbo.RegionMultipliers", "Utilities", c => c.Double(nullable: false));
            AlterColumn("dbo.RegionMultipliers", "RentOrMortgage", c => c.Double(nullable: false));
            AlterColumn("dbo.RegionMultipliers", "RestaurantsAndDining", c => c.Double(nullable: false));
            AlterColumn("dbo.RegionMultipliers", "Groceries", c => c.Double(nullable: false));
            AlterColumn("dbo.IncomeMultipliers", "Education", c => c.Double(nullable: false));
            AlterColumn("dbo.IncomeMultipliers", "Entertainment", c => c.Double(nullable: false));
            AlterColumn("dbo.IncomeMultipliers", "HealthCare", c => c.Double(nullable: false));
            AlterColumn("dbo.IncomeMultipliers", "Gasoline", c => c.Double(nullable: false));
            AlterColumn("dbo.IncomeMultipliers", "Vehicles", c => c.Double(nullable: false));
            AlterColumn("dbo.IncomeMultipliers", "Clothing", c => c.Double(nullable: false));
            AlterColumn("dbo.IncomeMultipliers", "HouseholdEquipment", c => c.Double(nullable: false));
            AlterColumn("dbo.IncomeMultipliers", "Household", c => c.Double(nullable: false));
            AlterColumn("dbo.IncomeMultipliers", "Telephone", c => c.Double(nullable: false));
            AlterColumn("dbo.IncomeMultipliers", "Utilities", c => c.Double(nullable: false));
            AlterColumn("dbo.IncomeMultipliers", "RentOrMortgage", c => c.Double(nullable: false));
            AlterColumn("dbo.IncomeMultipliers", "RestaurantsAndDining", c => c.Double(nullable: false));
            AlterColumn("dbo.IncomeMultipliers", "Groceries", c => c.Double(nullable: false));
        }
    }
}
