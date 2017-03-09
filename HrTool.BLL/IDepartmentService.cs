using HrTool.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrTool.BLL
{
    public interface IDepartmentService
    {
        IList<Department> GetAllDepartments();
        Department GetDepartmentById(string departmentId);
        void CreateDepartment(Department departmentToCreate);
        void DeleteDepartment(string departmentId);
        void UpdateDepartment(Department departmentToUpdate);
    }
}
