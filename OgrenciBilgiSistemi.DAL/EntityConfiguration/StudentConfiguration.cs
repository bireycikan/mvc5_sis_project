using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DAL.EntityConfiguration
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            HasKey(s => s.Id);

            Property(s => s.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(s => s.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            Property(s => s.LastName)
                .HasMaxLength(50)
                .IsRequired();

            Property(s => s.StudentNumber)
                .HasMaxLength(10)
                .IsRequired();

            Property(s => s.Gender)
                .HasColumnType("bit")
                .IsRequired();

            Property(s => s.DateOfBirth)
                .HasColumnType("date")
                .IsRequired();

            Property(s => s.StartingDate)
                .HasColumnType("date")
                .IsRequired();

            Property(s => s.EndingDate)
                .HasColumnType("date")
                .IsOptional();

            HasRequired(s => s.City)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.CityId)
                .WillCascadeOnDelete(false);

            HasRequired(s => s.EducationType)
                .WithMany(e => e.Students)
                .HasForeignKey(s => s.EducationTypeId)
                .WillCascadeOnDelete(false);

            HasOptional(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.DepartmentId)
                .WillCascadeOnDelete(false);

            HasOptional(s => s.Faculty)
                .WithMany(f => f.Students)
                .HasForeignKey(s => s.FacultyId)
                .WillCascadeOnDelete(false);

            HasOptional(s => s.GraduateType)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GraduateTypeId)
                .WillCascadeOnDelete(false);

            HasOptional(s => s.University)
                .WithMany(u => u.Students)
                .HasForeignKey(s => s.UniversityId)
                .WillCascadeOnDelete(false);
        }
    }
}
