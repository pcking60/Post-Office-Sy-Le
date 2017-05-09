namespace PostOffice.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialversion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceAttributes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceId = c.Int(nullable: false),
                        AttributeName = c.String(),
                        BenefitPercent = c.Single(nullable: false),
                        AttributeType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Services");
            DropTable("dbo.ServiceAttributes");
        }
    }
}
