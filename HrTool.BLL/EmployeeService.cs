using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrTool.Domain;
using HrTool.DAL;

namespace HrTool.BLL
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository _repository;

        public EmployeeService()
        {
            _repository = new Repository();
        }

        public void CreateEmployee(Employee employeeToCreate)
        {
            employeeToCreate.EmployeeId = Guid.NewGuid().ToString();
            _repository.CreateEmployee(employeeToCreate);
        }

        public void DeleteEmployee(string employeeId)
        {
            _repository.DeleteEmployee(employeeId);
        }

        public IList<Employee> GetAllEmployees()
        {
            return _repository.GetAllEmployees();
        }

        public Employee GetEmployeeById(string employeeId)
        {
            return _repository.GetEmployeeById(employeeId);
        }

        public void UpdateEmployee(Employee employeeToUpdate)
        {
            _repository.UpdateEmployee(employeeToUpdate);
        }
    }
}
