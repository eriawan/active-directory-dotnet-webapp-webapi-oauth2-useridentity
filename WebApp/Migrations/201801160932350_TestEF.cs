namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestEF : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TokenCacheEntries",
                c => new
                    {
                        TokenCacheEntryID = c.Int(nullable: false, identity: true),
                        userObjId = c.String(),
                        cacheBits = c.Binary(),
                        LastWrite = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TokenCacheEntryID);
            
            CreateTable(
                "dbo.UserStateValues",
                c => new
                    {
                        UserStateValueID = c.Int(nullable: false, identity: true),
                        userObjId = c.String(),
                        stateGuid = c.String(),
                    })
                .PrimaryKey(t => t.UserStateValueID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserStateValues");
            DropTable("dbo.TokenCacheEntries");
        }
    }
}
