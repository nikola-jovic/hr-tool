using HrTool.BLL;
using HrTool.WEB.Models;
using System;
using System.Collections.Generic;
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
        // GET:
        // CREATE EMPLOYEE
        public ActionResult Create()
        {
            return View();
        }
        // POST:
        // CREATE EMPLOYEE

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
                    Wage = new Domain.Wage(employee.InitialWage, employee.InitialWage, new List<Domain.WageChange>())

                }
            });

            return RedirectToAction("List");
        }

        // GET:
        // CREATE WAGE BONUS
        public ActionResult CreateWageBonus(string id)
        {
            var myEmployee = _employeeService.GetEmployeeById(id);
            var model = new CreateWageBonusViewModel
            {
                EmployeeId = myEmployee.EmployeeId
            };
            return View(model);
        }
        // POST:
        // CREATE WAGE BONUS
        [HttpPost]
        public ActionResult CreateWageBonus(CreateWageBonusViewModel wageBonus)
        {
            var myEmployee = _employeeService.GetEmployeeById(wageBonus.EmployeeId);
            myEmployee.EmploymentDetails.WageBonuses.Add(new Domain.WageBonus
            {
                BonusAmount = wageBonus.BonusAmount,
                DateOfBonus = wageBonus.DateOfBonus,
                Note = wageBonus.Note
            });
            _employeeService.UpdateEmployee(myEmployee);

            return RedirectToAction("Details", new { id = myEmployee.EmployeeId });
        }

        // GET:
        // CREATE TRAINING
        public ActionResult CreateTraining(string id)
        {
            var myEmployee = _employeeService.GetEmployeeById(id);
            var model = new CreateTrainingViewModel
            {
                EmployeeId = myEmployee.EmployeeId
            };
            return View(model);
        }
        // POST:
        // CREATE TRAINING
        [HttpPost]
        public ActionResult CreateTraining(CreateTrainingViewModel training)
        {
            var myEmployee = _employeeService.GetEmployeeById(training.EmployeeId);
            myEmployee.EmploymentDetails.Trainings.Add(new Domain.Training
            {
                Name = training.Name,
                Started = training.Started,
                Completed = training.Completed,
                Description = training.Description
            });
            _employeeService.UpdateEmployee(myEmployee);

            return RedirectToAction("Details", new { id = myEmployee.EmployeeId });
        }

        // GET:
        // CREATE CONFERENCE
        public ActionResult CreateConference(string id)
        {
            var myEmployee = _employeeService.GetEmployeeById(id);
            var model = new CreateConferenceViewModel
            {
                EmployeeId = myEmployee.EmployeeId
            };
            return View(model);
        }
        // POST:
        // CREATE CONFERENCE
        [HttpPost]
        public ActionResult CreateConference(CreateConferenceViewModel conference)
        {
            var myEmployee = _employeeService.GetEmployeeById(conference.EmployeeId);
            myEmployee.EmploymentDetails.Conferences.Add(new Domain.Conference
            {
                Name = conference.Name,
                Started = conference.Started,
                Completed = conference.Completed,
                Description = conference.Description,
                Location = conference.Location
            });
            _employeeService.UpdateEmployee(myEmployee);

            return RedirectToAction("Details", new { id = myEmployee.EmployeeId });
        }

        // GET:
        // CREATE CERTIFICATE
        public ActionResult CreateCertificate(string id)
        {
            var myEmployee = _employeeService.GetEmployeeById(id);
            var model = new CreateCertificateViewModel
            {
                EmployeeId = myEmployee.EmployeeId
            };
            return View(model);
        }
        // POST:
        // CREATE CERTIFICATE
        [HttpPost]
        public ActionResult CreateCertificate(CreateCertificateViewModel certificate)
        {
            var myEmployee = _employeeService.GetEmployeeById(certificate.EmployeeId);
            myEmployee.EmploymentDetails.Certificates.Add(new Domain.Certificate
            {
                Name = certificate.Name,
                URL = certificate.URL,
                IsPermanent = certificate.IsPermanent,
                ValidFromDate = certificate.ValidFromDate,
                ValidToDate = certificate.ValidToDate,
                Description = certificate.Description
            });
            _employeeService.UpdateEmployee(myEmployee);

            return RedirectToAction("Details", new { id = myEmployee.EmployeeId });
        }

        // GET:
        // CREATE EDUCATION
        public ActionResult CreateEducation(string id)
        {
            var myEmployee = _employeeService.GetEmployeeById(id);
            var model = new CreateEducationViewModel
            {
                EmployeeId = myEmployee.EmployeeId
            };
            return View(model);
        }
        // POST:
        // CREATE EDUCATION
        [HttpPost]
        public ActionResult CreateEducation(CreateEducationViewModel education)
        {
            var myEmployee = _employeeService.GetEmployeeById(education.EmployeeId);
            myEmployee.EmploymentDetails.Education.Add(new Domain.Education
            {
                Name = education.Name,
                Description = education.Description,
                FromDate = education.FromDate.ToUniversalTime(),
                ToDate = education.ToDate.ToUniversalTime()
            });
            _employeeService.UpdateEmployee(myEmployee);

            return RedirectToAction("Details", new { id = myEmployee.EmployeeId });
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


        //EDIT EditPersonalDetails
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

        //**************************************************************************************************

        //EDIT EditWageDetails
        public ActionResult EditWageDetails(string id)
        {
            var myEmployee = _employeeService.GetEmployeeById(id);


            var employeeWage = new UpdateWageDetailsViewModel
            {
                EmployeeId = myEmployee.EmployeeId,
                InitialWage = myEmployee.EmploymentDetails.Wage.InitialWage,
                CurrentWage = myEmployee.EmploymentDetails.Wage.CurrentWage
            };

            return View(employeeWage);
        }

        //EDIT EditWageDetails
        [HttpPost]
        public ActionResult EditWageDetails(UpdateWageDetailsViewModel employeeWage)
        {
            var myEmployee = _employeeService.GetEmployeeById(employeeWage.EmployeeId);
            if (myEmployee.EmploymentDetails.Wage.WageChanges == null)
            {
                myEmployee.EmploymentDetails.Wage.WageChanges = new List<Domain.WageChange>();
            }
            var result = employeeWage.CurrentWage - myEmployee.EmploymentDetails.Wage.CurrentWage;

            if (result > 0)
            {
                myEmployee.EmploymentDetails.Wage.WageChanges.Add(new Domain.WageChange
                {
                    ChangeAmount = result,
                    DateOfChange = DateTime.Now,
                    IsDecrease = false
                });
            }
            else if (result < 0)
            {
                myEmployee.EmploymentDetails.Wage.WageChanges.Add(new Domain.WageChange
                {
                    ChangeAmount = Math.Abs(result),
                    DateOfChange = DateTime.Now,
                    IsDecrease = true
                });
            }

            myEmployee.EmploymentDetails.Wage.InitialWage = employeeWage.InitialWage;
            myEmployee.EmploymentDetails.Wage.CurrentWage = employeeWage.CurrentWage;

            _employeeService.UpdateEmployee(myEmployee);

            return RedirectToAction("Details", new { id = employeeWage.EmployeeId });
        }



        //**************************************************************************************************

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