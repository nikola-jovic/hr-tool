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
    }
}
