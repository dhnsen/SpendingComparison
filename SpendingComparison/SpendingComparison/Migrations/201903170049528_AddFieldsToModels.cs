namespace SpendingComparison.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldsToModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IncomeMultipliers", "Utilities", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.IncomeMultipliers", "Telephone", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.IncomeMultipliers", "Household", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.IncomeMultipliers", "HouseholdEquipment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.IncomeMultipliers", "Clothing", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.IncomeMultipliers", "Vehicles", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.IncomeMultipliers", "Gasoline", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.IncomeMultipliers", "HealthCare", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.IncomeMultipliers", "Entertainment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.IncomeMultipliers", "Education", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.RegionMultipliers", "Utilities", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.RegionMultipliers", "Telephone", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.RegionMultipliers", "Household", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.RegionMultipliers", "HouseholdEquipment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.RegionMultipliers", "Clothing", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.RegionMultipliers", "Vehicles", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.RegionMultipliers", "Gasoline", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.RegionMultipliers", "HealthCare", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.RegionMultipliers", "Entertainment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.RegionMultipliers", "Education", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StandardSpendings", "Utilities", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StandardSpendings", "Telephone", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StandardSpendings", "Household", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StandardSpendings", "HouseholdEquipment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StandardSpendings", "Clothing", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StandardSpendings", "Vehicles", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StandardSpendings", "Gasoline", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StandardSpendings", "HealthCare", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StandardSpendings", "Entertainment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StandardSpendings", "Education", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.IncomeMultipliers", "ElectricAndGas");
            DropColumn("dbo.RegionMultipliers", "ElectricAndGas");
            DropColumn("dbo.StandardSpendings", "ElectricAndGas");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StandardSpendings", "ElectricAndGas", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.RegionMultipliers", "ElectricAndGas", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.IncomeMultipliers", "ElectricAndGas", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.StandardSpendings", "Education");
            DropColumn("dbo.StandardSpendings", "Entertainment");
            DropColumn("dbo.StandardSpendings", "HealthCare");
            DropColumn("dbo.StandardSpendings", "Gasoline");
            DropColumn("dbo.StandardSpendings", "Vehicles");
            DropColumn("dbo.StandardSpendings", "Clothing");
            DropColumn("dbo.StandardSpendings", "HouseholdEquipment");
            DropColumn("dbo.StandardSpendings", "Household");
            DropColumn("dbo.StandardSpendings", "Telephone");
            DropColumn("dbo.StandardSpendings", "Utilities");
            DropColumn("dbo.RegionMultipliers", "Education");
            DropColumn("dbo.RegionMultipliers", "Entertainment");
            DropColumn("dbo.RegionMultipliers", "HealthCare");
            DropColumn("dbo.RegionMultipliers", "Gasoline");
            DropColumn("dbo.RegionMultipliers", "Vehicles");
            DropColumn("dbo.RegionMultipliers", "Clothing");
            DropColumn("dbo.RegionMultipliers", "HouseholdEquipment");
            DropColumn("dbo.RegionMultipliers", "Household");
            DropColumn("dbo.RegionMultipliers", "Telephone");
            DropColumn("dbo.RegionMultipliers", "Utilities");
            DropColumn("dbo.IncomeMultipliers", "Education");
            DropColumn("dbo.IncomeMultipliers", "Entertainment");
            DropColumn("dbo.IncomeMultipliers", "HealthCare");
            DropColumn("dbo.IncomeMultipliers", "Gasoline");
            DropColumn("dbo.IncomeMultipliers", "Vehicles");
            DropColumn("dbo.IncomeMultipliers", "Clothing");
            DropColumn("dbo.IncomeMultipliers", "HouseholdEquipment");
            DropColumn("dbo.IncomeMultipliers", "Household");
            DropColumn("dbo.IncomeMultipliers", "Telephone");
            DropColumn("dbo.IncomeMultipliers", "Utilities");
        }
    }
}
