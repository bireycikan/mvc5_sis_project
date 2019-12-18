namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OnDeleteSetNullUniversityIdInStudentsTable : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Students ADD CONSTRAINT FK_UniversityId FOREIGN KEY (UniversityId) REFERENCES Universities (Id) ON DELETE SET NULL");
        }

        public override void Down()
        {
        }
    }
}
