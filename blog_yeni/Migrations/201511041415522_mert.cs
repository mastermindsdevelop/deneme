namespace blog_yeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.iletisims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        emailAddress = c.String(),
                        phoneNumber = c.String(),
                        yorum = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.iletisims");
        }
    }
}
