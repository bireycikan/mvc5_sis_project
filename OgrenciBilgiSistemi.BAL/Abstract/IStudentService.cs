using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.BAL.Abstract
{
    public interface IStudentService
    {
        Student GetStudentById(int id);
        List<Student> GetStudents();
        List<Student> GetStudentsByUniversityId(short id);

        void Create(Student student);
        void Update(Student student);
        void Delete(Student student);
    }
}
