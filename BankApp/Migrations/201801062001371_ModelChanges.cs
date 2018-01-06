namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "Emailaddress", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "Emailaddress", c => c.String(maxLength: 50));
        }
    }
}
