namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OnDeleteSetNullDepartmentIdInStudentsTable : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Students ADD CONSTRAINT FK_DepartmentId FOREIGN KEY (DepartmentId) REFERENCES Departments (Id) ON DELETE SET NULL");
        }
        
        public override void Down()
        {
        }
    }
}
