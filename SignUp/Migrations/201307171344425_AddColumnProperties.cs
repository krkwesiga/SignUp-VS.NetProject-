namespace SignUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnProperties : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SignUps", "FirstName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.SignUps", "LastName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.SignUps", "EmailAdress", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SignUps", "EmailAdress", c => c.String(nullable: false));
            AlterColumn("dbo.SignUps", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.SignUps", "FirstName", c => c.String(nullable: false));
        }
    }
}
