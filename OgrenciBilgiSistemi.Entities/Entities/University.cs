using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Entities.Entities
{
    public class University
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string RectorName { get; set; }
        public DateTime DateOfFoundation { get; set; }
        public string Description { get; set; }

        public City City { get; set; }
        public byte CityId { get; set; }

        public UniversityType UniversityType { get; set; }
        public byte UniversityTypeId { get; set; }

        public ICollection<EducationType> EducationTypes { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<UniversityFaculty> UniversityFaculties { get; set; }
    }
}
