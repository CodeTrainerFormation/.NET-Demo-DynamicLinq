namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Configuration.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Rank = c.Int(nullable: false),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("School.Person", t => t.ID)
                .Index(t => t.ID);
            
            AddColumn("School.Teacher", "Salary", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("Configuration.Employee", "ID", "School.Person");
            DropIndex("Configuration.Employee", new[] { "ID" });
            DropColumn("School.Teacher", "Salary");
            DropTable("Configuration.Employee");
        }
    }
}
