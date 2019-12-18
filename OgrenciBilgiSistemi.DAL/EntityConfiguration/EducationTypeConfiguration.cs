using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DAL.EntityConfiguration
{
    public class EducationTypeConfiguration : EntityTypeConfiguration<EducationType>
    {
        public EducationTypeConfiguration()
        {
            HasKey(e => e.Id);

            Property(e => e.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired();

            HasMany(e => e.Students)
                .WithRequired(s => s.EducationType)
                .HasForeignKey(s => s.EducationTypeId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.Universities)
                .WithMany(u => u.EducationTypes)
                .Map(conf => 
                {
                    conf.ToTable("UniversityEducationTypes");
                    conf.MapLeftKey("EducationTypeId");
                    conf.MapRightKey("UniversityId");
                });
        }
    }
}
