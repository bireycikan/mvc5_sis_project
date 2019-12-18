using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Entities.Entities
{
    public class Faculty
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string DeanName { get; set; }
        public string Description { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<UniversityFaculty> UniversityFaculties { get; set; }
    }
}
