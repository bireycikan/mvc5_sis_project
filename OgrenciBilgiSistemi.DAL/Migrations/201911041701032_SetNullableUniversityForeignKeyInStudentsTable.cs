namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNullableUniversityForeignKeyInStudentsTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Students", new[] { "UniversityId" });
            AlterColumn("dbo.Students", "UniversityId", c => c.Short());
            CreateIndex("dbo.Students", "UniversityId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "UniversityId" });
            AlterColumn("dbo.Students", "UniversityId", c => c.Short(nullable: false));
            CreateIndex("dbo.Students", "UniversityId");
        }
    }
}
