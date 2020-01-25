namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "School.Classroom",
                c => new
                    {
                        ClassroomID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Floor = c.Int(nullable: false),
                        Corridor = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ClassroomID);
            
            CreateTable(
                "School.Person",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Age);
            
            CreateTable(
                "School.Student",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Classroom_ClassroomID = c.Int(),
                        Average = c.Double(nullable: false),
                        IsClassDelegate = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("School.Person", t => t.ID)
                .ForeignKey("School.Classroom", t => t.Classroom_ClassroomID)
                .Index(t => t.ID)
                .Index(t => t.Classroom_ClassroomID);
            
            CreateTable(
                "School.Teacher",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Classroom_ClassroomID = c.Int(),
                        Discipline = c.String(maxLength: 100),
                        HiringDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("School.Person", t => t.ID)
                .ForeignKey("School.Classroom", t => t.Classroom_ClassroomID)
                .Index(t => t.ID)
                .Index(t => t.Classroom_ClassroomID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("School.Teacher", "Classroom_ClassroomID", "School.Classroom");
            DropForeignKey("School.Teacher", "ID", "School.Person");
            DropForeignKey("School.Student", "Classroom_ClassroomID", "School.Classroom");
            DropForeignKey("School.Student", "ID", "School.Person");
            DropIndex("School.Teacher", new[] { "Classroom_ClassroomID" });
            DropIndex("School.Teacher", new[] { "ID" });
            DropIndex("School.Student", new[] { "Classroom_ClassroomID" });
            DropIndex("School.Student", new[] { "ID" });
            DropIndex("School.Person", new[] { "Age" });
            DropTable("School.Teacher");
            DropTable("School.Student");
            DropTable("School.Person");
            DropTable("School.Classroom");
        }
    }
}
