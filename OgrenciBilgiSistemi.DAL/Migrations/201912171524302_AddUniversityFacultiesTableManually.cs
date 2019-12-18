namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddUniversityFacultiesTableManually : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UniversityFaculties",
                c => new
                {
                    UniversityId = c.Short(nullable: false),
                    FacultyId = c.Short(nullable: false),
                })
                .PrimaryKey(t => new { t.UniversityId, t.FacultyId })
                .ForeignKey("dbo.Universities", t => t.UniversityId, cascadeDelete: true)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.UniversityFaculties", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.UniversityFaculties", "UniversityId", "dbo.Universities");
            DropTable("dbo.UniversityFaculties");
        }
    }
}
