namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUniversityFacultiesIntermediateTableWithDummyData : DbMigration
    {
        public override void Up()
        {
            // Veriler gerçek değildir!

            Sql(@"INSERT INTO UniversityFaculties VALUES (1,1)
INSERT INTO UniversityFaculties VALUES (2,1)
INSERT INTO UniversityFaculties VALUES (3,1)
INSERT INTO UniversityFaculties VALUES (4,1)
INSERT INTO UniversityFaculties VALUES (5,1)
INSERT INTO UniversityFaculties VALUES (6,1)
INSERT INTO UniversityFaculties VALUES (7,1)
INSERT INTO UniversityFaculties VALUES (1,2)
INSERT INTO UniversityFaculties VALUES (2,2)
INSERT INTO UniversityFaculties VALUES (5,2)
INSERT INTO UniversityFaculties VALUES (1,3)
INSERT INTO UniversityFaculties VALUES (2,3)
INSERT INTO UniversityFaculties VALUES (3,3)
INSERT INTO UniversityFaculties VALUES (6,4)
INSERT INTO UniversityFaculties VALUES (7,4)
INSERT INTO UniversityFaculties VALUES (1,5)
INSERT INTO UniversityFaculties VALUES (3,5)
INSERT INTO UniversityFaculties VALUES (5,5)
INSERT INTO UniversityFaculties VALUES (7,5)
INSERT INTO UniversityFaculties VALUES (1,6)
INSERT INTO UniversityFaculties VALUES (1,7)
INSERT INTO UniversityFaculties VALUES (2,8)
INSERT INTO UniversityFaculties VALUES (3,8)
INSERT INTO UniversityFaculties VALUES (5,8)
INSERT INTO UniversityFaculties VALUES (6,9)
INSERT INTO UniversityFaculties VALUES (7,9)
INSERT INTO UniversityFaculties VALUES (5,10)
INSERT INTO UniversityFaculties VALUES (6,10)
INSERT INTO UniversityFaculties VALUES (7,10)
INSERT INTO UniversityFaculties VALUES (6,11)
INSERT INTO UniversityFaculties VALUES (1,12)
INSERT INTO UniversityFaculties VALUES (1,13)
INSERT INTO UniversityFaculties VALUES (2,14)
INSERT INTO UniversityFaculties VALUES (4,14)
INSERT INTO UniversityFaculties VALUES (6,14)
");
        }
        
        public override void Down()
        {
        }
    }
}
