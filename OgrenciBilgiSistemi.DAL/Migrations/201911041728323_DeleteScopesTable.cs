namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteScopesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FacultyScopes", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.FacultyScopes", "ScopeId", "dbo.Scopes");
            DropForeignKey("dbo.DepartmentScopes", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.DepartmentScopes", "ScopeId", "dbo.Scopes");
            DropIndex("dbo.FacultyScopes", new[] { "FacultyId" });
            DropIndex("dbo.FacultyScopes", new[] { "ScopeId" });
            DropIndex("dbo.DepartmentScopes", new[] { "DepartmentId" });
            DropIndex("dbo.DepartmentScopes", new[] { "ScopeId" });
            DropTable("dbo.Scopes");
            DropTable("dbo.FacultyScopes");
            DropTable("dbo.DepartmentScopes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DepartmentScopes",
                c => new
                    {
                        DepartmentId = c.Short(nullable: false),
                        ScopeId = c.Short(nullable: false),
                    })
                .PrimaryKey(t => new { t.DepartmentId, t.ScopeId });
            
            CreateTable(
                "dbo.FacultyScopes",
                c => new
                    {
                        FacultyId = c.Short(nullable: false),
                        ScopeId = c.Short(nullable: false),
                    })
                .PrimaryKey(t => new { t.FacultyId, t.ScopeId });
            
            CreateTable(
                "dbo.Scopes",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.DepartmentScopes", "ScopeId");
            CreateIndex("dbo.DepartmentScopes", "DepartmentId");
            CreateIndex("dbo.FacultyScopes", "ScopeId");
            CreateIndex("dbo.FacultyScopes", "FacultyId");
            AddForeignKey("dbo.DepartmentScopes", "ScopeId", "dbo.Scopes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DepartmentScopes", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FacultyScopes", "ScopeId", "dbo.Scopes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FacultyScopes", "FacultyId", "dbo.Faculties", "Id", cascadeDelete: true);
        }
    }
}
