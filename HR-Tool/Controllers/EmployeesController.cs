using HR_Tool.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR_Tool.Controllers
{
    public class EmployeesController : Controller
    {

        private static readonly List<EmployeeModel> EmployeesList = new List<EmployeeModel>
        {
            new EmployeeModel { FirstName = "Nikola", LastName = "Jovic", UMCN = "1807991800063", Address = "Jastrebacka 23", DateOfBirth = DateTime.ParseExact("18/07/1991", "dd/MM/yyyy", CultureInfo.InvariantCulture) , Email = "nikola.telep@gmail.com", HomePhoneNum = "021/403-011", MobPhoneNum = "069/1807-1991"}
        };

        // GET: Employees
        public ActionResult List()
        {

            return View(EmployeesList);
        }
    }
}