namespace MovieR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "genre", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "releasedate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "releasedate", c => c.String());
            AlterColumn("dbo.Movies", "genre", c => c.String());
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
