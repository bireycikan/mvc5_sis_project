using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Entities.Entities
{
    public class Department
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string ChairmanName { get; set; }
        public string Description { get; set; }

        public Faculty Faculty { get; set; }
        public short FacultyId { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
