namespace SpendingComparison.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IncomeMultipliers",
                c => new
                    {
                        MultiplierIncomeId = c.Int(nullable: false, identity: true),
                        IncomeRangeId = c.Int(nullable: false),
                        RestaurantsAndDining = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Groceries = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RentOrMortgage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ElectricAndGas = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MultiplierIncomeId)
                .ForeignKey("dbo.IncomeRanges", t => t.IncomeRangeId, cascadeDelete: true)
                .Index(t => t.IncomeRangeId);
            
            CreateTable(
                "dbo.IncomeRanges",
                c => new
                    {
                        IncomeRangeId = c.Int(nullable: false, identity: true),
                        BottomIncomeRange = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TopIncomeRange = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.IncomeRangeId);
            
            CreateTable(
                "dbo.RegionMultipliers",
                c => new
                    {
                        RegionMultiplierId = c.Int(nullable: false, identity: true),
                        RegionId = c.Int(nullable: false),
                        RestaurantsAndDining = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Groceries = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RentOrMortgage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ElectricAndGas = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.RegionMultiplierId)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        RegionId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RegionId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.StandardSpendings",
                c => new
                    {
                        StandardSpendingId = c.Int(nullable: false, identity: true),
                        CalendarYear = c.Int(nullable: false),
                        RestaurantsAndDining = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Groceries = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RentOrMortgage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ElectricAndGas = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.StandardSpendingId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.RegionMultipliers", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.IncomeMultipliers", "IncomeRangeId", "dbo.IncomeRanges");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.RegionMultipliers", new[] { "RegionId" });
            DropIndex("dbo.IncomeMultipliers", new[] { "IncomeRangeId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.StandardSpendings");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Regions");
            DropTable("dbo.RegionMultipliers");
            DropTable("dbo.IncomeRanges");
            DropTable("dbo.IncomeMultipliers");
        }
    }
}
