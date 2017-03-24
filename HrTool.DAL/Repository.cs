using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrTool.Domain;
using MongoDB.Driver;

namespace HrTool.DAL
{
    public class Repository : IRepository
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public Repository()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("HRTool");
        }

        //GET ALL EMPLOYEES
        public IList<Employee> GetAllEmployees()
        {
            return _database.GetCollection<Employee>("Employees").Find(_ => true).ToList();
        }

        //CREATE
        public void CreateEmployee(Employee employeeToCreate)
        {
            _database.GetCollection<Employee>("Employees").InsertOne(employeeToCreate);
        }

        //DELETE
        public void DeleteEmployee(string employeeId)
        {
            _database.GetCollection<Employee>("Employees").DeleteOne(x => x.EmployeeId == employeeId);
        }

        //UPDATE
        public void UpdateEmployee(Employee employeeToUpdate)
        {
            var filter = Builders<Employee>.Filter.Eq("EmployeeId", employeeToUpdate.EmployeeId);
            _database.GetCollection<Employee>("Employees").FindOneAndReplace(filter, employeeToUpdate);
        }

        //GET EMPLOYEE BY ID
        public Employee GetEmployeeById(string employeeId)
        {
            return _database.GetCollection<Employee>("Employees").Find(x => x.EmployeeId == employeeId).FirstOrDefault();
        }


        //*****************************************************************************************

        //GET ALL DEPARTMENTS
        public IList<Department> GetAllDepartments()
        {
            return _database.GetCollection<Department>("Departments").Find(_ => true).ToList();
        }
        //GET DEPARTMENT BY ID
        public Department GetDepartmentById(string departmentId)
        {
            return _database.GetCollection<Department>("Departments").Find(x => x.DepartmentId == departmentId).FirstOrDefault();
        }
        //CREATE
        public void CreateDepartment(Department departmentToCreate)
        {
            _database.GetCollection<Department>("Departments").InsertOne(departmentToCreate);
        }
        //DELETE
        public void DeleteDepartment(string departmentId)
        {
            _database.GetCollection<Department>("Departments").DeleteOne(x => x.DepartmentId == departmentId);
        }
        //UPDATE
        public void UpdateDepartment(Department departmentToUpdate)
        {
            var filter = Builders<Department>.Filter.Eq("DepartmentId", departmentToUpdate.DepartmentId);
            _database.GetCollection<Department>("Departments").FindOneAndReplace(filter, departmentToUpdate);
        }

        //*****************************************************************************************

        //GET ALL EMPLOYEE BENEFITS
        public IList<EmployeeBenefit> GetAllEmployeeBenefits()
        {
            return _database.GetCollection<EmployeeBenefit>("EmployeeBenefits").Find(_ => true).ToList();
        }
        //GET EmployeeBenefit BY ID
        public EmployeeBenefit GetEmployeeBenefitById(string employeeBenefitId)
        {
            return _database.GetCollection<EmployeeBenefit>("EmployeeBenefits").Find(x => x.EmployeeBenefitId == employeeBenefitId).FirstOrDefault();
        }
        //CREATE
        public void CreateEmployeeBenefit(EmployeeBenefit employeeBenefitToCreate)
        {
            _database.GetCollection<EmployeeBenefit>("EmployeeBenefits").InsertOne(employeeBenefitToCreate);
        }
        //DELETE
        public void DeleteEmployeeBenefit(string employeeBenefitId)
        {
            _database.GetCollection<EmployeeBenefit>("EmployeeBenefits").DeleteOne(x => x.EmployeeBenefitId == employeeBenefitId);
        }
        //UPDATE
        public void UpdateEmployeeBenefit(EmployeeBenefit employeeBenefitToUpdate)
        {
            var filter = Builders<EmployeeBenefit>.Filter.Eq("EmployeeBenefitId", employeeBenefitToUpdate.EmployeeBenefitId);
            _database.GetCollection<EmployeeBenefit>("EmployeeBenefits").FindOneAndReplace(filter, employeeBenefitToUpdate);
        }
    }
}
