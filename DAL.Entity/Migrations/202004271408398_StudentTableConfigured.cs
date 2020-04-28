﻿namespace DAL.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentTableConfigured : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
        }
    }
}
