namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNullableDepartmentForeignKeyInStudentsTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            AlterColumn("dbo.Students", "DepartmentId", c => c.Short());
            CreateIndex("dbo.Students", "DepartmentId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            AlterColumn("dbo.Students", "DepartmentId", c => c.Short(nullable: false));
            CreateIndex("dbo.Students", "DepartmentId");
        }
    }
}
