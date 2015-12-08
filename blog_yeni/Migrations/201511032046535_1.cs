namespace blog_yeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.editors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        baslik = c.String(),
                        editors_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.editors", t => t.editors_Id)
                .Index(t => t.editors_Id);
            
            CreateTable(
                "dbo.hakkimizdas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.posts", "editors_Id", "dbo.editors");
            DropIndex("dbo.posts", new[] { "editors_Id" });
            DropTable("dbo.hakkimizdas");
            DropTable("dbo.posts");
            DropTable("dbo.editors");
        }
    }
}
