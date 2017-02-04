using HR_Tool.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HR_Tool.Controllers
{
    public class EmployeesController : Controller
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public EmployeesController()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("HRTool");
        }


        // GET: Employees
        public ActionResult List()
        {
           var myEmployees = _database.GetCollection<EmployeeModel>("Employees").Find(_ => true).ToList();
            return View(myEmployees);
        }
        // GET: /Dinners/Create

        public ActionResult Create()
        {
            return View();
        }
        // POST: /Dinners/Create

        [HttpPost]
        public async Task<ActionResult> Create(EmployeeModel employee)
        {

            _database.GetCollection<EmployeeModel>("Employees").InsertOne(employee);
            
            return View(employee);
        }


    }

}