namespace Blog_Project_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutPage",
                c => new
                    {
                        AboutPageId = c.Int(nullable: false, identity: true),
                        TitleName = c.String(),
                        AboutDescription = c.String(),
                    })
                .PrimaryKey(t => t.AboutPageId);
            
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        ArticleTitle = c.String(),
                        ArticleContent = c.String(unicode: false, storeType: "text"),
                        ArticleImagePath = c.String(),
                        ArticleDescription = c.String(),
                        ArticleDate = c.DateTime(nullable: false),
                        ArticleClick = c.Int(nullable: false),
                        ArticleCategory = c.String(),
                        ArticleTag = c.String(),
                    })
                .PrimaryKey(t => t.ArticleId);
            
            CreateTable(
                "dbo.ContactPage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        EmailAddress = c.String(),
                        PhoneNumber = c.String(),
                        LinkedInProfile = c.String(),
                        GitHubProfile = c.String(),
                        TitleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactPage");
            DropTable("dbo.Article");
            DropTable("dbo.AboutPage");
        }
    }
}
