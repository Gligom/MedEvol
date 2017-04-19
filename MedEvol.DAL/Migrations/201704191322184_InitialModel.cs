namespace MedEvol.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        County_CountyId = c.Int(),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Counties", t => t.County_CountyId)
                .Index(t => t.County_CountyId);
            
            CreateTable(
                "dbo.Counties",
                c => new
                    {
                        CountyId = c.Int(nullable: false, identity: true),
                        CountyName = c.String(),
                    })
                .PrimaryKey(t => t.CountyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "County_CountyId", "dbo.Counties");
            DropIndex("dbo.Cities", new[] { "County_CountyId" });
            DropTable("dbo.Counties");
            DropTable("dbo.Cities");
        }
    }
}
