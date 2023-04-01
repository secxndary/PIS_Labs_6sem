namespace PIS_Lab4.Migrations.PhoneBooks
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.PhoneBooks", "PhoneNumber", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.PhoneBooks", new[] { "PhoneNumber" });
        }
    }
}
