using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Entities.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }

        public City City { get; set; }
        public byte CityId { get; set; }

        public EducationType EducationType { get; set; }
        public byte EducationTypeId { get; set; }

        public Department Department { get; set; }
        public short? DepartmentId { get; set; }

        public Faculty Faculty { get; set; }
        public short? FacultyId { get; set; }

        public GraduateType GraduateType { get; set; }
        public byte? GraduateTypeId { get; set; }

        public University University { get; set; }
        public short? UniversityId { get; set; }
    }
}
