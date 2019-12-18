using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DAL.EntityConfiguration
{
    public class GraduateTypeConfiguration : EntityTypeConfiguration<GraduateType>
    {
        public GraduateTypeConfiguration()
        {
            HasKey(g => g.Id);

            Property(g => g.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(g => g.Name)
                .HasMaxLength(50)
                .IsRequired();

            HasMany(g => g.Students)
                .WithOptional(s => s.GraduateType)
                .HasForeignKey(s => s.GraduateTypeId)
                .WillCascadeOnDelete(false);
        }
    }
}
