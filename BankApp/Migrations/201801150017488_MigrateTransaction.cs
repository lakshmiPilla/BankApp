namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateTransaction : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "Emailaddress", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "Emailaddress", c => c.String(maxLength: 100));
        }
    }
}
