using OgrenciBilgiSistemi.BAL.Abstract;
using OgrenciBilgiSistemi.DAL.Abstract;
using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.BAL.Concrete
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public void Create(Department department)
        {
            _departmentRepository.Create(department);
        }

        public void Delete(Department department)
        {
            _departmentRepository.Delete(department);
        }

        public Department GetDepartmentById(short id)
        {
            return _departmentRepository.GetById(id);
        }

        public Department GetDepartmentByStudentId(int id)
        {
            return _departmentRepository.GetSingle(d => d.Students.Any(s => s.Id == id));
        }

        public List<Department> GetDepartments()
        {
            return _departmentRepository
                .GetAll()
                .Include(d => d.Faculty)
                .OrderBy(d => d.Name)
                .ToList();
        }

        public void Update(Department department)
        {
            _departmentRepository.Update(department);
        }
    }
}
