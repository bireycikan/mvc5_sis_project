namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUniversitiesTableWithDummyData : DbMigration
    {
        public override void Up()
        {
            // Veriler gerçek değildir!

            Sql(@"INSERT INTO Universities VALUES ('ODTÜ', 'Prof. Dr. Senem Çelik', '1996-07-11', '', 6, 1)
INSERT INTO Universities VALUES ('İTÜ', 'Prof. Dr. Halil Özkan', '1986-08-12', '', 34, 1)
INSERT INTO Universities VALUES ('YTÜ', 'Prof. Dr. Birey Çıkan', '1911-06-13', '', 34, 1)
INSERT INTO Universities VALUES ('Hacettepe Üniversitesi', 'Prof. Dr. Buğra Toprak', '1976-03-09', '', 6, 1)
INSERT INTO Universities VALUES ('Akdeniz Üniversitesi', 'Prof. Dr. Mustafa Aygar', '1996-07-15', '', 7, 1)
INSERT INTO Universities VALUES ('Ankara Üniversitesi', 'Prof. Dr. Cemre Duymaz', '1997-10-11', '', 6, 1)
INSERT INTO Universities VALUES ('İstanbul Üniversitesi', 'Prof. Dr. Ercüment Çözer', '1998-11-11', '', 34, 1)
INSERT INTO Universities VALUES ('Dokuz Eylül Üniversitesi', 'Prof. Dr. Harun Sinanoğlu', '1999-01-01', '', 35, 1)
INSERT INTO Universities VALUES ('İstanbul Aydın Üniversitesi', 'Prof. Dr. Behzat Çözer', '2000-02-06', '', 34, 2)
INSERT INTO Universities VALUES ('Anadolu Üniversitesi', 'Prof. Dr. İclal Akkoyun', '1978-03-11', '', 26, 1)
INSERT INTO Universities VALUES ('Sabancı Üniversitesi', 'Prof. Dr. Ahmet Polat Çörekçi', '2000-12-04', '', 34, 2)
INSERT INTO Universities VALUES ('Yeditepe Üniversitesi', 'Prof. Dr. Sarper Akış', '2001-07-23', '', 34, 2)
INSERT INTO Universities VALUES ('Çanakkale 18 Mart Üniversitesi', 'Prof. Dr. Elif Tuğçe Aktaş', '2004-05-12', '', 17, 1)
INSERT INTO Universities VALUES ('Bilkent Üniversitesi', 'Prof. Dr. İhsan Doğramacı', '1989-05-10', '', 6, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
