namespace DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intoDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        age = c.Int(nullable: false),
                        email = c.String(nullable: false),
                        designation = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
