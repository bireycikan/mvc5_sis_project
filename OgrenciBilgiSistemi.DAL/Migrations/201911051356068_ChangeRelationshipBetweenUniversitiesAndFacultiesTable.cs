namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRelationshipBetweenUniversitiesAndFacultiesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Faculties", "UniversityId", "dbo.Universities");
            DropIndex("dbo.Faculties", new[] { "UniversityId" });
            CreateTable(
                "dbo.UniversityFaculties",
                c => new
                    {
                        FacultyId = c.Short(nullable: false),
                        UniversityId = c.Short(nullable: false),
                    })
                .PrimaryKey(t => new { t.FacultyId, t.UniversityId })
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .ForeignKey("dbo.Universities", t => t.UniversityId, cascadeDelete: true)
                .Index(t => t.FacultyId)
                .Index(t => t.UniversityId);
            
            DropColumn("dbo.Faculties", "UniversityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Faculties", "UniversityId", c => c.Short());
            DropForeignKey("dbo.UniversityFaculties", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.UniversityFaculties", "FacultyId", "dbo.Faculties");
            DropIndex("dbo.UniversityFaculties", new[] { "UniversityId" });
            DropIndex("dbo.UniversityFaculties", new[] { "FacultyId" });
            DropTable("dbo.UniversityFaculties");
            CreateIndex("dbo.Faculties", "UniversityId");
            AddForeignKey("dbo.Faculties", "UniversityId", "dbo.Universities", "Id");
        }
    }
}
