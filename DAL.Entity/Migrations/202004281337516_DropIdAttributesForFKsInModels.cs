namespace DAL.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropIdAttributesForFKsInModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "SpecialityId", "dbo.Specialities");
            DropForeignKey("dbo.Groups", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Groups", "SpecialityId", "dbo.Specialities");
            DropIndex("dbo.Courses", new[] { "SpecialityId" });
            DropIndex("dbo.Groups", new[] { "RoomId" });
            DropIndex("dbo.Groups", new[] { "SpecialityId" });
            RenameColumn(table: "dbo.Courses", name: "SpecialityId", newName: "Speciality_Id");
            RenameColumn(table: "dbo.Groups", name: "RoomId", newName: "Room_Id");
            RenameColumn(table: "dbo.Groups", name: "SpecialityId", newName: "Speciality_Id");
            AlterColumn("dbo.Courses", "Speciality_Id", c => c.Int());
            AlterColumn("dbo.Groups", "Room_Id", c => c.Int());
            AlterColumn("dbo.Groups", "Speciality_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Speciality_Id");
            CreateIndex("dbo.Groups", "Room_Id");
            CreateIndex("dbo.Groups", "Speciality_Id");
            AddForeignKey("dbo.Courses", "Speciality_Id", "dbo.Specialities", "Id");
            AddForeignKey("dbo.Groups", "Room_Id", "dbo.Rooms", "Id");
            AddForeignKey("dbo.Groups", "Speciality_Id", "dbo.Specialities", "Id");
            DropColumn("dbo.Specialities", "CourseId");
            DropColumn("dbo.Students", "SpecialityId");
            DropColumn("dbo.Trainers", "SpecilityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trainers", "SpecilityId", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "SpecialityId", c => c.Int(nullable: false));
            AddColumn("dbo.Specialities", "CourseId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Groups", "Speciality_Id", "dbo.Specialities");
            DropForeignKey("dbo.Groups", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.Courses", "Speciality_Id", "dbo.Specialities");
            DropIndex("dbo.Groups", new[] { "Speciality_Id" });
            DropIndex("dbo.Groups", new[] { "Room_Id" });
            DropIndex("dbo.Courses", new[] { "Speciality_Id" });
            AlterColumn("dbo.Groups", "Speciality_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Groups", "Room_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Courses", "Speciality_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Groups", name: "Speciality_Id", newName: "SpecialityId");
            RenameColumn(table: "dbo.Groups", name: "Room_Id", newName: "RoomId");
            RenameColumn(table: "dbo.Courses", name: "Speciality_Id", newName: "SpecialityId");
            CreateIndex("dbo.Groups", "SpecialityId");
            CreateIndex("dbo.Groups", "RoomId");
            CreateIndex("dbo.Courses", "SpecialityId");
            AddForeignKey("dbo.Groups", "SpecialityId", "dbo.Specialities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Groups", "RoomId", "dbo.Rooms", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "SpecialityId", "dbo.Specialities", "Id", cascadeDelete: true);
        }
    }
}
