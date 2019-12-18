namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNullableUniversityForeignKeyInFacultiesTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Faculties", new[] { "UniversityId" });
            AlterColumn("dbo.Faculties", "UniversityId", c => c.Short());
            CreateIndex("dbo.Faculties", "UniversityId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Faculties", new[] { "UniversityId" });
            AlterColumn("dbo.Faculties", "UniversityId", c => c.Short(nullable: false));
            CreateIndex("dbo.Faculties", "UniversityId");
        }
    }
}
