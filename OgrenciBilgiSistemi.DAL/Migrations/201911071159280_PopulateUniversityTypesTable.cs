namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUniversityTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO UniversityTypes VALUES ('Devlet')
INSERT INTO UniversityTypes VALUES ('Vakıf')");
        }
        
        public override void Down()
        {
        }
    }
}
