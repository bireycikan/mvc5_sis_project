namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveExistingUniversityFacultiesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UniversityFaculties", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.UniversityFaculties", "UniversityId", "dbo.Universities");
            //CreateTable(
            //    "dbo.UniversityFaculties",
            //    c => new
            //        {
            //            UniversityId = c.Short(nullable: false),
            //            FacultyId = c.Short(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.UniversityId, t.FacultyId })
            //    .ForeignKey("dbo.Universities", t => t.UniversityId, cascadeDelete: true)
            //    .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true);

            DropTable("dbo.UniversityFaculties");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UniversityFaculties",
                c => new
                    {
                        FacultyId = c.Short(nullable: false),
                        UniversityId = c.Short(nullable: false),
                    })
                .PrimaryKey(t => new { t.FacultyId, t.UniversityId });
            
            //DropForeignKey("dbo.UniversityFaculties", "FacultyId", "dbo.Faculties");
            //DropForeignKey("dbo.UniversityFaculties", "UniversityId", "dbo.Universities");
            //DropTable("dbo.UniversityFaculties");
            AddForeignKey("dbo.UniversityFaculties", "UniversityId", "dbo.Universities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UniversityFaculties", "FacultyId", "dbo.Faculties", "Id", cascadeDelete: true);
        }
    }
}
