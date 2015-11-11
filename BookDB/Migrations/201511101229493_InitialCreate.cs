namespace BookDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        PublishYear = c.DateTime(nullable: false),
                        GenreID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Genre", t => t.GenreID, cascadeDelete: true)
                .Index(t => t.GenreID);
            
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameGenre = c.String(),
                        StyleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Style", t => t.StyleID, cascadeDelete: true)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.Style",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameStyle = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Genre", "StyleID", "dbo.Style");
            DropForeignKey("dbo.Book", "GenreID", "dbo.Genre");
            DropIndex("dbo.Genre", new[] { "StyleID" });
            DropIndex("dbo.Book", new[] { "GenreID" });
            DropTable("dbo.Style");
            DropTable("dbo.Genre");
            DropTable("dbo.Book");
        }
    }
}
