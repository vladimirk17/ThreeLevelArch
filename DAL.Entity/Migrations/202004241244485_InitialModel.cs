namespace DAL.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            Sql("Truncate table dbo.Students");
            Sql("Truncate table dbo.Courses");

            CreateTable(
                "dbo.Specialities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        NumberOfCourses = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Trainer_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trainers", t => t.Trainer_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Trainer_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        GroupName = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        SpecialityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GroupId)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.Specialities", t => t.SpecialityId, cascadeDelete: true)
                .Index(t => t.RoomId)
                .Index(t => t.SpecialityId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomNum = c.Int(nullable: false),
                        Floor = c.Int(nullable: false),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        SpecilityId = c.Int(nullable: false),
                        Group_GroupId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_GroupId)
                .Index(t => t.Group_GroupId);
            
            AddColumn("dbo.Courses", "SpecialityId", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "LastName", c => c.String());
            AddColumn("dbo.Students", "City", c => c.String());
            AddColumn("dbo.Students", "Phone", c => c.String());
            AddColumn("dbo.Students", "SpecialityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "SpecialityId");
            AddForeignKey("dbo.Courses", "SpecialityId", "dbo.Specialities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Specialities", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Trainers", "Group_GroupId", "dbo.Groups");
            DropForeignKey("dbo.Specialities", "Trainer_Id", "dbo.Trainers");
            DropForeignKey("dbo.Groups", "SpecialityId", "dbo.Specialities");
            DropForeignKey("dbo.Groups", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Courses", "SpecialityId", "dbo.Specialities");
            DropIndex("dbo.Trainers", new[] { "Group_GroupId" });
            DropIndex("dbo.Groups", new[] { "SpecialityId" });
            DropIndex("dbo.Groups", new[] { "RoomId" });
            DropIndex("dbo.Specialities", new[] { "Student_Id" });
            DropIndex("dbo.Specialities", new[] { "Trainer_Id" });
            DropIndex("dbo.Courses", new[] { "SpecialityId" });
            DropColumn("dbo.Students", "SpecialityId");
            DropColumn("dbo.Students", "Phone");
            DropColumn("dbo.Students", "City");
            DropColumn("dbo.Students", "LastName");
            DropColumn("dbo.Courses", "SpecialityId");
            DropTable("dbo.Trainers");
            DropTable("dbo.Rooms");
            DropTable("dbo.Groups");
            DropTable("dbo.Specialities");
        }
    }
}
