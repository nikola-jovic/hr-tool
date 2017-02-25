using HR_Tool.Core;
using HR_Tool.Models;
using MongoDB.Bson;
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
        public ActionResult Create(EmployeeModel employee)
        {
            employee.PersonalDetails.EmployeeId = Guid.NewGuid().ToString();
            _database.GetCollection<EmployeeModel>("Employees").InsertOne(employee);

            return RedirectToAction("List");
        }

        //DELETE
        public ActionResult Delete(string id)
        {
            var myEmployee = _database.GetCollection<EmployeeModel>("Employees").Find(x => x.PersonalDetails.EmployeeId == id).FirstOrDefault();
            return View(myEmployee);
        }

        //DELETE
        [HttpPost]
        public ActionResult Delete(string id, FormCollection formcollection)
        {
            _database.GetCollection<EmployeeModel>("Employees").DeleteOne(x => x.PersonalDetails.EmployeeId == id);
            return RedirectToAction("List");
        }


        //EDIT
        public ActionResult Edit(string id)
        {
            
            var myEmployee = _database.GetCollection<EmployeeModel>("Employees").Find(x => x.PersonalDetails.EmployeeId == id).FirstOrDefault();
            return View(myEmployee);
        }

        //EDIT
        [HttpPost]
        public ActionResult Edit(EmployeeModel employee)
        {

            var filter = Builders<EmployeeModel>.Filter.Eq("EmployeeId", employee.PersonalDetails.EmployeeId);
            _database.GetCollection<EmployeeModel>("Employees").FindOneAndReplace(filter, employee);

            return View();
        }

        //DETAILS
        public ActionResult Details(string id)
        {
            var myEmployee = _database.GetCollection<EmployeeModel>("Employees").Find(x => x.PersonalDetails.EmployeeId == id).FirstOrDefault();
            return View(myEmployee);
        }


        //WAGE-CHANGES FOR PARTIAL VIEW

        //[HttpPost]
        //public ActionResult GenerateWageChanges(Wage wage)
        //[ChildActionOnly]
        //public ActionResult SummaryPanel_Partial(Wage wage)
        //{
           
            // Check whether this request is comming with javascript, if so, we know that we are going to add contact details.
    //        if (Request.IsAjaxRequest())
    //        {
    //            WageChange wageChange = new WageChange();
    //            wageChange.DateOfChange = wage.WageChange.DateOfChange;
    //            wageChange.IsDecrease = wage.WageChange.IsDecrease;
    //            wageChange.ChangeAmount = wage.WageChange.ChangeAmount;

    //            if (wage.WageChanges == null)
    //            {
    //                wage.WageChanges = new List<WageChange>();
    //            }

    //            wage.WageChanges.Add(wageChange);

    //            return PartialView("_WageChanges", wage);
    //        }
    //        return null;
    //    }
    }

}