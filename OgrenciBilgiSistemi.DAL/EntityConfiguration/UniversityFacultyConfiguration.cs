using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DAL.EntityConfiguration
{
    public class UniversityFacultyConfiguration : EntityTypeConfiguration<UniversityFaculty>
    {
        public UniversityFacultyConfiguration()
        {
            HasKey(k => new { k.UniversityId, k.FacultyId });
        }
    }
}
