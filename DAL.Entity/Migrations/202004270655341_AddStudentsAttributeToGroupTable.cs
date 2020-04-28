namespace DAL.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentsAttributeToGroupTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Group_GroupId", c => c.Int());
            CreateIndex("dbo.Students", "Group_GroupId");
            AddForeignKey("dbo.Students", "Group_GroupId", "dbo.Groups", "GroupId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Group_GroupId", "dbo.Groups");
            DropIndex("dbo.Students", new[] { "Group_GroupId" });
            DropColumn("dbo.Students", "Group_GroupId");
        }
    }
}
