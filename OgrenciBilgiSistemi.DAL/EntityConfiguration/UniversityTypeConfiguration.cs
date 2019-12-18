using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DAL.EntityConfiguration
{
    public class UniversityTypeConfiguration : EntityTypeConfiguration<UniversityType>
    {
        public UniversityTypeConfiguration()
        {
            HasKey(u => u.Id);

            Property(u => u.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(u => u.Name)
                .HasMaxLength(50)
                .IsRequired();

            HasMany(u => u.Universities)
                .WithRequired(u => u.UniversityType)
                .HasForeignKey(u => u.UniversityTypeId)
                .WillCascadeOnDelete(false);
        }
    }
}
