namespace blog_yeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mert4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.iletisims", "name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.iletisims", "name", c => c.String(nullable: false, maxLength: 60));
        }
    }
}
