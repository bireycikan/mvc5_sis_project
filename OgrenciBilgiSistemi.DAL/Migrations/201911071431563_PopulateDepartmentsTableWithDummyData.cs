namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDepartmentsTableWithDummyData : DbMigration
    {
        public override void Up()
        {
            // Veriler gerçek değildir!

            Sql(@"INSERT INTO Departments VALUES ('Mimarlık Bölümü', 'Doç. Dr. Merve Ece Altıok', '', 1)
INSERT INTO Departments VALUES ('Şehir ve Bölge Planlama Bölümü', 'Doç. Dr. Fatma Özlem Acar', '', 1)
INSERT INTO Departments VALUES ('Endüstri Ürünleri Tasarımı Bölümü', 'Doç. Dr. Atahan Adanır', '', 1)
INSERT INTO Departments VALUES ('Biyolojik Bilimler Bölümü', 'Doç. Dr. Şennur Ağnar', '', 2)
INSERT INTO Departments VALUES ('Kimya Bölümü', 'Doç. Dr. Lemi Akarçay', '', 2)
INSERT INTO Departments VALUES ('Tarih Bölümü', 'Doç. Dr. Cihan Akarpınar', '', 2)
INSERT INTO Departments VALUES ('Sosyoloji Bölümü', 'Doç. Dr. Mehmetcan Akar', '', 2)
INSERT INTO Departments VALUES ('Psikoloji Bölümü', 'Doç. Dr. Servet Akçagünay', '', 2)
INSERT INTO Departments VALUES ('İşletme Bölümü', 'Doç. Dr. Çilem Akçay', '', 3)
INSERT INTO Departments VALUES ('İktisat Bölümü', 'Doç. Dr. Ercüment Akıncılar', '', 3)
INSERT INTO Departments VALUES ('Uluslararası İlişkiler Bölümü', 'Doç. Dr. Berker Akkıray', '', 3)
INSERT INTO Departments VALUES ('Bilgisayar ve Öğretim Teknolojileri Eğitimi Bölümü', 'Doç. Dr. Ata Kerem Akman', '', 4)
INSERT INTO Departments VALUES ('Beden Eğitimi ve Spor Bölümü', 'Doç. Dr. Pekcan Aksöz', '', 4)
INSERT INTO Departments VALUES ('Bilgisayar Mühendisliği Bölümü', 'Doç. Dr. Birey Çıkan', '', 5)
INSERT INTO Departments VALUES ('Elektrik ve Elektronik Mühendisliği Bölümü', 'Doç. Dr. İlma Aldağ', '', 5)
INSERT INTO Departments VALUES ('Elektrik Mühendisliği Bölümü', 'Doç. Dr. Kutlu Alibeyoğlu', '', 5)
INSERT INTO Departments VALUES ('Makina Mühendisliği Bölümü', 'Doç. Dr. Mazlum Altan', '', 5)
INSERT INTO Departments VALUES ('Temel İngilizce Bölümü', 'Doç. Dr. Nesibe Alkan', '', 7)
INSERT INTO Departments VALUES ('Modern Diller Bölümü', 'Doç. Dr. Erna Aluç', '', 7)
INSERT INTO Departments VALUES ('Akademik Yazı Merkezi', 'Doç. Dr. Cansev Arat', '', 7)
INSERT INTO Departments VALUES ('Endüstriyel Otomasyon Programı', 'Doç. Dr. Şeyda Nur Arıkan', '', 6)
INSERT INTO Departments VALUES ('Kaynak Teknolojisi Programı', 'Doç. Dr. Sevtap Atan', '', 6)");
        }
        
        public override void Down()
        {
        }
    }
}
