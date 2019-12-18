namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNullableFacultyForeignKeyInStudentsTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Students", new[] { "FacultyId" });
            AlterColumn("dbo.Students", "FacultyId", c => c.Short());
            CreateIndex("dbo.Students", "FacultyId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "FacultyId" });
            AlterColumn("dbo.Students", "FacultyId", c => c.Short(nullable: false));
            CreateIndex("dbo.Students", "FacultyId");
        }
    }
}
