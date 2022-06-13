namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2CodeLastName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "studentLastName", c => c.String(nullable: false));
            AddColumn("dbo.Students", "studentCode", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "studentAddress", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "studentAddress", c => c.String(nullable: false));
            DropColumn("dbo.Students", "studentCode");
            DropColumn("dbo.Students", "studentLastName");
        }
    }
}
