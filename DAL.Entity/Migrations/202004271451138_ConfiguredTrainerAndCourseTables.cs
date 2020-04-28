namespace DAL.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfiguredTrainerAndCourseTables : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Trainers", "FirstName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Trainers", "LastName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trainers", "LastName", c => c.String());
            AlterColumn("dbo.Trainers", "FirstName", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
        }
    }
}
