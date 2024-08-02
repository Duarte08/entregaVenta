namespace entregaVenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalesProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalesId = c.Int(nullable: false),
                        ProductsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductsId, cascadeDelete: true)
                .ForeignKey("dbo.Sales", t => t.SalesId, cascadeDelete: true)
                .Index(t => t.SalesId)
                .Index(t => t.ProductsId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Client = c.String(nullable: false, maxLength: 100),
                        Description = c.String(),
                        Contact = c.String(maxLength: 100),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreationDate = c.DateTime(nullable: false),
                        PaidDate = c.DateTime(),
                        IsPaid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Mail = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesProducts", "SalesId", "dbo.Sales");
            DropForeignKey("dbo.SalesProducts", "ProductsId", "dbo.Products");
            DropIndex("dbo.SalesProducts", new[] { "ProductsId" });
            DropIndex("dbo.SalesProducts", new[] { "SalesId" });
            DropTable("dbo.Users");
            DropTable("dbo.Sales");
            DropTable("dbo.SalesProducts");
            DropTable("dbo.Products");
        }
    }
}
