namespace MySQLTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBook_TitleYomigana : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "TitleYomigana", c => c.String(nullable: false, maxLength: 100, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "TitleYomigana");
        }
    }
}
