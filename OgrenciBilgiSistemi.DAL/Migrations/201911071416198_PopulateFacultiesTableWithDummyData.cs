namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFacultiesTableWithDummyData : DbMigration
    {
        public override void Up()
        {
            //Veriler gerçek değildir!
            
            Sql(@"INSERT INTO Faculties VALUES ('Mimarlık Fakültesi', 'Doç. Dr. Merve Ece Altıok', '')
INSERT INTO Faculties VALUES ('Fen Edebiyat Fakültesi', 'Doç. Dr. Halim Aral', '')
INSERT INTO Faculties VALUES ('İktisadi ve İdari Bilimler Fakültesi', 'Doç. Dr. Yasin Şükrü Arap', '')
INSERT INTO Faculties VALUES ('Eğitim Fakültesi', 'Doç. Dr. İzlem Arınç', '')
INSERT INTO Faculties VALUES ('Mühendislik Fakültesi', 'Doç. Dr. Birey Çıkan', '')
INSERT INTO Faculties VALUES ('Meslek Yüksekokulu', 'Doç. Dr. Edip Attila', '')
INSERT INTO Faculties VALUES ('Yabancı Diller Yüksekokulu', 'Doç. Dr. Saba Atmaca', '')
");
        }
        
        public override void Down()
        {
        }
    }
}
