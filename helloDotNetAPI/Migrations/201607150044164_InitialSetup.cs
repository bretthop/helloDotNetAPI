namespace helloDotNetAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HelloTestEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestProperty = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HelloTestEntities");
        }
    }
}
