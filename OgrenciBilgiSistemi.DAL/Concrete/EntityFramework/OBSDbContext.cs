using OgrenciBilgiSistemi.DAL.EntityConfiguration;
using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DAL.Concrete.EntityFramework
{
    public class OBSDbContext : DbContext
    {
        public OBSDbContext()
            : base("name=OBSConnection")
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EducationType> EducationTypes { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<GraduateType> GraduateTypes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<UniversityFaculty> UniversityFaculties { get; set; }
        public DbSet<UniversityType> UniversityTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CityConfiguration());
            modelBuilder.Configurations.Add(new DepartmentConfiguration());
            modelBuilder.Configurations.Add(new EducationTypeConfiguration());
            modelBuilder.Configurations.Add(new FacultyConfiguration());
            modelBuilder.Configurations.Add(new GraduateTypeConfiguration());
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new UniversityConfiguration());
            modelBuilder.Configurations.Add(new UniversityFacultyConfiguration());
            modelBuilder.Configurations.Add(new UniversityTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
