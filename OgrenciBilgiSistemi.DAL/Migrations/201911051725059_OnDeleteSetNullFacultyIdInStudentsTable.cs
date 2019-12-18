namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OnDeleteSetNullFacultyIdInStudentsTable : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Students ADD CONSTRAINT FK_FacultyId FOREIGN KEY (FacultyId) REFERENCES Faculties (Id) ON DELETE SET NULL");
        }

        public override void Down()
        {
        }
    }
}
