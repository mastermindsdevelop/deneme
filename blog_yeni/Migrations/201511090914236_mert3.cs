namespace blog_yeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mert3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.iletisims", "name", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.iletisims", "emailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.iletisims", "phoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.iletisims", "yorum", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.iletisims", "yorum", c => c.String());
            AlterColumn("dbo.iletisims", "phoneNumber", c => c.String());
            AlterColumn("dbo.iletisims", "emailAddress", c => c.String());
            AlterColumn("dbo.iletisims", "name", c => c.String());
        }
    }
}
