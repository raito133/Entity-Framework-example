namespace RecordLabelDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Birthdate = c.DateTime(nullable: false, storeType: "date"),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudioAlbums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        ReleaseDate = c.DateTime(nullable: false, storeType: "date"),
                        GenreId = c.Int(nullable: false),
                        ArtistId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artists", t => t.ArtistId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId)
                .Index(t => t.ArtistId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tracks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Length = c.Double(nullable: false),
                        StudioAlbumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudioAlbums", t => t.StudioAlbumId, cascadeDelete: true)
                .Index(t => t.StudioAlbumId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tracks", "StudioAlbumId", "dbo.StudioAlbums");
            DropForeignKey("dbo.StudioAlbums", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.StudioAlbums", "ArtistId", "dbo.Artists");
            DropForeignKey("dbo.Artists", "CountryId", "dbo.Countries");
            DropIndex("dbo.Tracks", new[] { "StudioAlbumId" });
            DropIndex("dbo.StudioAlbums", new[] { "ArtistId" });
            DropIndex("dbo.StudioAlbums", new[] { "GenreId" });
            DropIndex("dbo.Artists", new[] { "CountryId" });
            DropTable("dbo.Tracks");
            DropTable("dbo.Genres");
            DropTable("dbo.StudioAlbums");
            DropTable("dbo.Countries");
            DropTable("dbo.Artists");
        }
    }
}
