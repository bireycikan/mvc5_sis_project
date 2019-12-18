using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DAL.EntityConfiguration
{
    public class FacultyConfiguration : EntityTypeConfiguration<Faculty>
    {
        public FacultyConfiguration()
        {
            HasKey(f => f.Id);

            Property(f => f.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(f => f.Name)
                .HasMaxLength(100)
                .IsRequired();

            Property(f => f.DeanName)
                .HasMaxLength(100)
                .IsRequired();

            Property(f => f.Description)
                .HasMaxLength(255)
                .IsOptional();

            HasMany(f => f.UniversityFaculties)
                .WithRequired(uf => uf.Faculty)
                .HasForeignKey(uf => uf.FacultyId);

            HasMany(f => f.Departments)
                .WithRequired(d => d.Faculty)
                .HasForeignKey(d => d.FacultyId)
                .WillCascadeOnDelete(false);

            HasMany(f => f.Students)
                .WithOptional(s => s.Faculty)
                .HasForeignKey(s => s.FacultyId)
                .WillCascadeOnDelete(false);
        }
    }
}
