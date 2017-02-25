using HrTool.BLL;
using HrTool.WEB.Models;
using System.Linq;
using System.Web.Mvc;

namespace HrTool.WEB.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController()
        {
            _employeeService = new EmployeeService();
        }

        // GET: Employees
        public ActionResult List()
        {
            var myEmployees = _employeeService.GetAllEmployees();
            var listOfEmployees = myEmployees.Select(x => new BasicEmployeeDetailsViewModel
            {
                EmployeeId = x.EmployeeId,
                FirstName = x.PersonalDetails.FirstName,
                LastName = x.PersonalDetails.LastName,
                Email = x.PersonalDetails.Email,
                MobPhoneNumber = x.PersonalDetails.MobPhoneNum,
                Address = x.PersonalDetails.Address
            });
            return View(listOfEmployees);
        }
        // GET: /Dinners/Create

        public ActionResult Create()
        {
            return View();
        }
        // POST: /Dinners/Create

        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel employee)
        {

            _employeeService.CreateEmployee(new Domain.Employee
            {

                PersonalDetails = new Domain.PersonalDetails
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    UMCN = employee.UMCN,
                    Address = employee.Address,
                    DateOfBirth = employee.DateOfBirth,
                    Email = employee.Email,
                    HomePhoneNum = employee.HomePhoneNum,
                    MobPhoneNum = employee.MobPhoneNum,
                    MaritatStatus = employee.MaritatStatus

                },
                EmploymentDetails = new Domain.EmploymentDetails
                {

                    ContractType = employee.ContractType,
                    Wage = new Domain.Wage(employee.InitialWage, employee.InitialWage, null)

                }
            });

            return RedirectToAction("List");
        }

        //DELETE
        public ActionResult Delete(string id)
        {
            var myEmployee = _employeeService.GetEmployeeById(id);
            var employeeToDelete = new BasicEmployeeDetailsViewModel
            {
                EmployeeId = myEmployee.EmployeeId,
                FirstName = myEmployee.PersonalDetails.FirstName,
                LastName = myEmployee.PersonalDetails.LastName,
                Email = myEmployee.PersonalDetails.Email,
                MobPhoneNumber = myEmployee.PersonalDetails.MobPhoneNum,
                Address = myEmployee.PersonalDetails.Address
            };
            return View(employeeToDelete);
        }

        //DELETE
        [HttpPost]
        public ActionResult Delete(string id, FormCollection formcollection)
        {
            _employeeService.DeleteEmployee(id);
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
            var myEmployee = _employeeService.GetEmployeeById(id);
            var employee = new EmployeeDetailsViewModel
            {
                EmployeeId = myEmployee.EmployeeId,
                PersonalDetails = myEmployee.PersonalDetails,
                EmploymentDetails = myEmployee.EmploymentDetails
            };
            return View(employee);
        }


        
    }

}