namespace blog_yeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mert2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.posts", "altBaslik", c => c.String());
            AddColumn("dbo.posts", "icerik", c => c.String());
            AddColumn("dbo.posts", "tarih", c => c.String());
            AddColumn("dbo.posts", "resim", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.posts", "resim");
            DropColumn("dbo.posts", "tarih");
            DropColumn("dbo.posts", "icerik");
            DropColumn("dbo.posts", "altBaslik");
        }
    }
}
