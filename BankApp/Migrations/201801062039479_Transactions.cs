namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Transactions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        TransactionDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        Transctonamount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeOfTransaction = c.Int(nullable: false),
                        AcoountNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.Accounts", t => t.AcoountNumber, cascadeDelete: true)
                .Index(t => t.AcoountNumber);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "AcoountNumber", "dbo.Accounts");
            DropIndex("dbo.Transactions", new[] { "AcoountNumber" });
            DropTable("dbo.Transactions");
        }
    }
}
