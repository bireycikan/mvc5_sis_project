using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DAL.EntityConfiguration
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();

            HasMany(c => c.Students)
                .WithRequired(s => s.City)
                .HasForeignKey(s => s.CityId)
                .WillCascadeOnDelete(false);

            HasMany(c => c.Universities)
                .WithRequired(u => u.City)
                .HasForeignKey(u => u.CityId)
                .WillCascadeOnDelete(false);
        }
    }
}
