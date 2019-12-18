namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGraduateTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO GraduateTypes VALUES ('ÖNLİSANS')
INSERT INTO GraduateTypes VALUES ('LİSANS')
INSERT INTO GraduateTypes VALUES ('YÜKSEK LİSANS')
INSERT INTO GraduateTypes VALUES ('DOKTORA')");
        }
        
        public override void Down()
        {
        }
    }
}
