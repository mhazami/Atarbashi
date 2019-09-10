namespace Atarbashi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_DB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Content.Article",
                c => new
                    {
                        Title = c.String(nullable: false, maxLength: 128),
                        Abstract = c.String(nullable: false),
                        Orginal = c.String(nullable: false),
                        Enable = c.Boolean(nullable: false),
                        KeyWords = c.String(),
                        ArticleCategoryId = c.Int(nullable: false),
                        IsTrend = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Title)
                .ForeignKey("Content.ArticleCategory", t => t.ArticleCategoryId, cascadeDelete: true)
                .Index(t => t.ArticleCategoryId);
            
            CreateTable(
                "Content.ArticleCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Order = c.Byte(nullable: false),
                        Enable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Content.File",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.Binary(nullable: false),
                        Size = c.Byte(nullable: false),
                        FileName = c.String(nullable: false, maxLength: 250),
                        Extension = c.String(nullable: false, maxLength: 10),
                        Order = c.Byte(nullable: false),
                        Alt = c.String(),
                        Article_Title = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Content.Article", t => t.Article_Title)
                .Index(t => t.Article_Title);
            
            CreateTable(
                "Atarbashi.Customer",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EnterPriseNodeId = c.Guid(nullable: false),
                        IPAddress = c.String(nullable: false, maxLength: 16),
                        Usename = c.String(nullable: false, maxLength: 150),
                        Password = c.String(nullable: false, maxLength: 150),
                        RegisterDate = c.String(nullable: false, maxLength: 10),
                        RegisterTime = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Atarbashi.EnterPriseNode", t => t.EnterPriseNodeId, cascadeDelete: true)
                .Index(t => t.EnterPriseNodeId);
            
            CreateTable(
                "Atarbashi.EnterPriseNode",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 300),
                        Mobile = c.String(maxLength: 11),
                        Tel = c.String(maxLength: 11),
                        BirthDate = c.String(maxLength: 10),
                        NationalCode = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Atarbashi.ItemCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Enable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Security.Menu",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        Order = c.Byte(nullable: false),
                        ParentId = c.Guid(nullable: false),
                        IsShow = c.Boolean(nullable: false),
                        Enable = c.Boolean(nullable: false),
                        Icon = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Atarbashi.Newsletter",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 300),
                        SaveDate = c.String(nullable: false, maxLength: 10),
                        SaveTime = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Security.Role",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        Enable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Security.RoleMenu",
                c => new
                    {
                        RoleId = c.Guid(nullable: false),
                        MenuId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.MenuId })
                .ForeignKey("Security.Menu", t => t.MenuId, cascadeDelete: true)
                .ForeignKey("Security.Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.MenuId);
            
            CreateTable(
                "Security.User",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EnterPriseNodeId = c.Guid(nullable: false),
                        Username = c.String(nullable: false, maxLength: 250),
                        Password = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Atarbashi.EnterPriseNode", t => t.EnterPriseNodeId, cascadeDelete: true)
                .Index(t => t.EnterPriseNodeId);
            
            CreateTable(
                "Content.UserComments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ArticleId = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 150),
                        ParentId = c.Guid(),
                        Comment = c.String(nullable: false),
                        SaveDate = c.String(nullable: false, maxLength: 10),
                        SaveTime = c.String(nullable: false, maxLength: 5),
                        Confirm = c.Boolean(nullable: false),
                        Like = c.Boolean(nullable: false),
                        IP = c.String(nullable: false, maxLength: 16),
                        Article_Title = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Content.Article", t => t.Article_Title)
                .Index(t => t.Article_Title);
            
            CreateTable(
                "Security.UserRole",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("Security.Role", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("Security.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Security.UserRole", "UserId", "Security.User");
            DropForeignKey("Security.UserRole", "RoleId", "Security.Role");
            DropForeignKey("Content.UserComments", "Article_Title", "Content.Article");
            DropForeignKey("Security.User", "EnterPriseNodeId", "Atarbashi.EnterPriseNode");
            DropForeignKey("Security.RoleMenu", "RoleId", "Security.Role");
            DropForeignKey("Security.RoleMenu", "MenuId", "Security.Menu");
            DropForeignKey("Atarbashi.Customer", "EnterPriseNodeId", "Atarbashi.EnterPriseNode");
            DropForeignKey("Content.File", "Article_Title", "Content.Article");
            DropForeignKey("Content.Article", "ArticleCategoryId", "Content.ArticleCategory");
            DropIndex("Security.UserRole", new[] { "RoleId" });
            DropIndex("Security.UserRole", new[] { "UserId" });
            DropIndex("Content.UserComments", new[] { "Article_Title" });
            DropIndex("Security.User", new[] { "EnterPriseNodeId" });
            DropIndex("Security.RoleMenu", new[] { "MenuId" });
            DropIndex("Security.RoleMenu", new[] { "RoleId" });
            DropIndex("Atarbashi.Customer", new[] { "EnterPriseNodeId" });
            DropIndex("Content.File", new[] { "Article_Title" });
            DropIndex("Content.Article", new[] { "ArticleCategoryId" });
            DropTable("Security.UserRole");
            DropTable("Content.UserComments");
            DropTable("Security.User");
            DropTable("Security.RoleMenu");
            DropTable("Security.Role");
            DropTable("Atarbashi.Newsletter");
            DropTable("Security.Menu");
            DropTable("Atarbashi.ItemCategory");
            DropTable("Atarbashi.EnterPriseNode");
            DropTable("Atarbashi.Customer");
            DropTable("Content.File");
            DropTable("Content.ArticleCategory");
            DropTable("Content.Article");
        }
    }
}
