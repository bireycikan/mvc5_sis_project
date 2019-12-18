using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DAL.EntityConfiguration
{
    public class UniversityConfiguration : EntityTypeConfiguration<University>
    {
        public UniversityConfiguration()
        {
            HasKey(u => u.Id);

            Property(u => u.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(u => u.Name)
                .HasMaxLength(100)
                .IsRequired();

            Property(u => u.RectorName)
                .HasMaxLength(100)
                .IsRequired();

            Property(u => u.DateOfFoundation)
                .HasColumnType("date")
                .IsRequired();

            Property(u => u.Description)
                .HasMaxLength(255)
                .IsOptional();

            HasRequired(u => u.City)
                .WithMany(c => c.Universities)
                .HasForeignKey(u => u.CityId)
                .WillCascadeOnDelete(false);

            HasRequired(u => u.UniversityType)
                .WithMany(u => u.Universities)
                .HasForeignKey(u => u.UniversityTypeId)
                .WillCascadeOnDelete(false);

            HasMany(u => u.EducationTypes)
                .WithMany(e => e.Universities)
                .Map(conf => 
                {
                    conf.ToTable("UniversityEducationTypes");
                    conf.MapLeftKey("UniversityId");
                    conf.MapRightKey("EducationTypeId");
                });

            HasMany(u => u.UniversityFaculties)
                .WithRequired(uf => uf.University)
                .HasForeignKey(uf => uf.UniversityId);

            HasMany(u => u.Students)
                .WithOptional(s => s.University)
                .HasForeignKey(s => s.UniversityId)
                .WillCascadeOnDelete(false);
        }
    }
}
