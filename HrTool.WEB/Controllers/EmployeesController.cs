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
        public ActionResult EditPersonalDetails(string id)
        {
            var myEmployee = _employeeService.GetEmployeeById(id);
            var personalDetailsModel = new UpdatePersonalDetailsViewModel
            {
                EmployeeId = myEmployee.EmployeeId,
                PersonalDetails = myEmployee.PersonalDetails
            };
            return View(personalDetailsModel);
        }

        //EDIT EditPersonalDetails
        [HttpPost]
        public ActionResult EditPersonalDetails(UpdatePersonalDetailsViewModel employee)
        {
            var myEmployee = _employeeService.GetEmployeeById(employee.EmployeeId);
            myEmployee.PersonalDetails = employee.PersonalDetails;
            _employeeService.UpdateEmployee(myEmployee);

            return RedirectToAction("Details", new { id = employee.EmployeeId });
        }

        //EDIT EditBasicEmploymentDetails
        public ActionResult EditBasicEmploymentDetails(string id)
        {
            var myEmployee = _employeeService.GetEmployeeById(id);
            var basicEmploymentDetailsModel = new UpdateBasicEmploymentDetailsViewModel
            {
                EmployeeId = myEmployee.EmployeeId,
                ContractType = myEmployee.EmploymentDetails.ContractType,
                EmploymentType = myEmployee.EmploymentDetails.EmploymentType,
                RecommendedByEmployee = myEmployee.EmploymentDetails.RecommendedByEmployee,
                AccountNumber = myEmployee.EmploymentDetails.AccountNumber
            };
            return View(basicEmploymentDetailsModel);
        }

        //EDIT EditBasicEmploymentDetails
        [HttpPost]
        public ActionResult EditBasicEmploymentDetails(UpdateBasicEmploymentDetailsViewModel employee)
        {
            var myEmployee = _employeeService.GetEmployeeById(employee.EmployeeId);
            myEmployee.EmploymentDetails.ContractType = employee.ContractType;
            myEmployee.EmploymentDetails.EmploymentType = employee.EmploymentType;
            myEmployee.EmploymentDetails.RecommendedByEmployee = employee.RecommendedByEmployee;
            myEmployee.EmploymentDetails.AccountNumber = employee.AccountNumber;

            _employeeService.UpdateEmployee(myEmployee);

            return RedirectToAction("Details", new { id = employee.EmployeeId });
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