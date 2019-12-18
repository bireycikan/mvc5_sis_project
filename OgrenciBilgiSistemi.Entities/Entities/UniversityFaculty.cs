using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Entities.Entities
{
    public class UniversityFaculty
    {
        public short UniversityId { get; set; }
        public University University { get; set; }

        public short FacultyId { get; set; }
        public Faculty Faculty { get; set; }
    }
}
