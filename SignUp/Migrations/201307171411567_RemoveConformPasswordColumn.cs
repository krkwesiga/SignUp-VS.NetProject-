namespace SignUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveConformPasswordColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SignUps", "ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SignUps", "ConfirmPassword", c => c.String(nullable: false));
        }
    }
}
