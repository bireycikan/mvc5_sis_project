namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEducationTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO EducationTypes VALUES ('Örgün Öğretim')
INSERT INTO EducationTypes VALUES ('İkinci Öğretim')
INSERT INTO EducationTypes VALUES ('Uzaktan Öğretim')
INSERT INTO EducationTypes VALUES ('Açık Öğretim')");
        }
        
        public override void Down()
        {
        }
    }
}
