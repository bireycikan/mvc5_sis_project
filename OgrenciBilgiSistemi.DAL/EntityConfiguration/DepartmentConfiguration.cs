using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DAL.EntityConfiguration
{
    public class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
        {
            HasKey(d => d.Id);

            Property(d => d.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(d => d.Name)
                .HasMaxLength(100)
                .IsRequired();

            Property(d => d.ChairmanName)
                .HasMaxLength(100)
                .IsRequired();

            Property(d => d.Description)
                .HasMaxLength(255)
                .IsOptional();

            HasMany(d => d.Students)
                .WithOptional(s => s.Department)
                .HasForeignKey(s => s.DepartmentId)
                .WillCascadeOnDelete(false);
        }
    }
}
