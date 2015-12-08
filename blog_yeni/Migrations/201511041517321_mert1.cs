namespace blog_yeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mert1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.editors", "userName", c => c.String());
            AddColumn("dbo.editors", "passWord", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.editors", "passWord");
            DropColumn("dbo.editors", "userName");
        }
    }
}
