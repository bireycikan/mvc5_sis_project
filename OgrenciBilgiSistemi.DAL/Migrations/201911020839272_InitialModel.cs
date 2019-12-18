namespace OgrenciBilgiSistemi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        StudentNumber = c.String(nullable: false, maxLength: 10),
                        Gender = c.Boolean(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false, storeType: "date"),
                        StartingDate = c.DateTime(nullable: false, storeType: "date"),
                        EndingDate = c.DateTime(storeType: "date"),
                        CityId = c.Byte(nullable: false),
                        EducationTypeId = c.Byte(nullable: false),
                        DepartmentId = c.Short(nullable: false),
                        FacultyId = c.Short(nullable: false),
                        GraduateTypeId = c.Byte(),
                        UniversityId = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.FacultyId)
                .ForeignKey("dbo.EducationTypes", t => t.EducationTypeId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .ForeignKey("dbo.GraduateTypes", t => t.GraduateTypeId)
                .ForeignKey("dbo.Universities", t => t.UniversityId)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .Index(t => t.CityId)
                .Index(t => t.EducationTypeId)
                .Index(t => t.DepartmentId)
                .Index(t => t.FacultyId)
                .Index(t => t.GraduateTypeId)
                .Index(t => t.UniversityId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        ChairmanName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 255),
                        FacultyId = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.FacultyId)
                .Index(t => t.FacultyId);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        DeanName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 255),
                        UniversityId = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Universities", t => t.UniversityId)
                .Index(t => t.UniversityId);
            
            CreateTable(
                "dbo.Scopes",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        RectorName = c.String(nullable: false, maxLength: 100),
                        DateOfFoundation = c.DateTime(nullable: false, storeType: "date"),
                        Description = c.String(maxLength: 255),
                        CityId = c.Byte(nullable: false),
                        UniversityTypeId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UniversityTypes", t => t.UniversityTypeId)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .Index(t => t.CityId)
                .Index(t => t.UniversityTypeId);
            
            CreateTable(
                "dbo.EducationTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UniversityTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GraduateTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FacultyScopes",
                c => new
                    {
                        FacultyId = c.Short(nullable: false),
                        ScopeId = c.Short(nullable: false),
                    })
                .PrimaryKey(t => new { t.FacultyId, t.ScopeId })
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .ForeignKey("dbo.Scopes", t => t.ScopeId, cascadeDelete: true)
                .Index(t => t.FacultyId)
                .Index(t => t.ScopeId);
            
            CreateTable(
                "dbo.UniversityEducationTypes",
                c => new
                    {
                        EducationTypeId = c.Byte(nullable: false),
                        UniversityId = c.Short(nullable: false),
                    })
                .PrimaryKey(t => new { t.EducationTypeId, t.UniversityId })
                .ForeignKey("dbo.EducationTypes", t => t.EducationTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Universities", t => t.UniversityId, cascadeDelete: true)
                .Index(t => t.EducationTypeId)
                .Index(t => t.UniversityId);
            
            CreateTable(
                "dbo.DepartmentScopes",
                c => new
                    {
                        DepartmentId = c.Short(nullable: false),
                        ScopeId = c.Short(nullable: false),
                    })
                .PrimaryKey(t => new { t.DepartmentId, t.ScopeId })
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Scopes", t => t.ScopeId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.ScopeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Universities", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Students", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Students", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.Students", "GraduateTypeId", "dbo.GraduateTypes");
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.DepartmentScopes", "ScopeId", "dbo.Scopes");
            DropForeignKey("dbo.DepartmentScopes", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Faculties", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.Universities", "UniversityTypeId", "dbo.UniversityTypes");
            DropForeignKey("dbo.UniversityEducationTypes", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.UniversityEducationTypes", "EducationTypeId", "dbo.EducationTypes");
            DropForeignKey("dbo.Students", "EducationTypeId", "dbo.EducationTypes");
            DropForeignKey("dbo.Students", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.FacultyScopes", "ScopeId", "dbo.Scopes");
            DropForeignKey("dbo.FacultyScopes", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.Departments", "FacultyId", "dbo.Faculties");
            DropIndex("dbo.DepartmentScopes", new[] { "ScopeId" });
            DropIndex("dbo.DepartmentScopes", new[] { "DepartmentId" });
            DropIndex("dbo.UniversityEducationTypes", new[] { "UniversityId" });
            DropIndex("dbo.UniversityEducationTypes", new[] { "EducationTypeId" });
            DropIndex("dbo.FacultyScopes", new[] { "ScopeId" });
            DropIndex("dbo.FacultyScopes", new[] { "FacultyId" });
            DropIndex("dbo.Universities", new[] { "UniversityTypeId" });
            DropIndex("dbo.Universities", new[] { "CityId" });
            DropIndex("dbo.Faculties", new[] { "UniversityId" });
            DropIndex("dbo.Departments", new[] { "FacultyId" });
            DropIndex("dbo.Students", new[] { "UniversityId" });
            DropIndex("dbo.Students", new[] { "GraduateTypeId" });
            DropIndex("dbo.Students", new[] { "FacultyId" });
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            DropIndex("dbo.Students", new[] { "EducationTypeId" });
            DropIndex("dbo.Students", new[] { "CityId" });
            DropTable("dbo.DepartmentScopes");
            DropTable("dbo.UniversityEducationTypes");
            DropTable("dbo.FacultyScopes");
            DropTable("dbo.GraduateTypes");
            DropTable("dbo.UniversityTypes");
            DropTable("dbo.EducationTypes");
            DropTable("dbo.Universities");
            DropTable("dbo.Scopes");
            DropTable("dbo.Faculties");
            DropTable("dbo.Departments");
            DropTable("dbo.Students");
            DropTable("dbo.Cities");
        }
    }
}
