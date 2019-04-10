namespace EF.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BooksAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ISBN = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ISBN);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
