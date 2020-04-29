namespace DAL.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustedDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Specialities", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Specialities", "Title", c => c.String());
        }
    }
}
