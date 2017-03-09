using HrTool.DAL;
using HrTool.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrTool.BLL
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IRepository _repository;

        public DepartmentService()
        {
            _repository = new Repository();
        }

        public void CreateDepartment(Department departmentToCreate)
        {
            departmentToCreate.DepartmentId = Guid.NewGuid().ToString();
            _repository.CreateDepartment(departmentToCreate);
        }

        public void DeleteDepartment(string departmentId)
        {
            _repository.DeleteEmployee(departmentId);
        }

        public IList<Department> GetAllDepartments()
        {
            return _repository.GetAllDepartments();
        }

        public Department GetDepartmentById(string departmentId)
        {
            return _repository.GetDepartmentById(departmentId);
        }

        public void UpdateDepartment(Department departmentToUpdate)
        {
            _repository.UpdateDepartment(departmentToUpdate);
        }
    }
}
