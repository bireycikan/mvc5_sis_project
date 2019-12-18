using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.BAL.Abstract
{
    public interface IDepartmentService
    {
        Department GetDepartmentById(short id);
        List<Department> GetDepartments();
        Department GetDepartmentByStudentId(int id);

        void Create(Department department);
        void Update(Department department);
        void Delete(Department department);
    }
}
