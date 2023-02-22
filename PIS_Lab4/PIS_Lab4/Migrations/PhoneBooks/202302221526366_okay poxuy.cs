namespace PIS_Lab4.Migrations.PhoneBooks
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class okaypoxuy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhoneBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhoneBooks");
        }
    }
}
