﻿using HrTool.BLL;
using HrTool.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HrTool.WEB.Controllers
{
    public class RegistryController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;

        public RegistryController()
        {
            _departmentService = new DepartmentService();
            _employeeService = new EmployeeService();
        }

        // GET: Registry
        public ActionResult ListDepartments()
        {
            var employees = _employeeService.GetAllEmployees();
            var myDepartments = _departmentService.GetAllDepartments();
            var listOfDepartment = myDepartments.Select(x => new DepartmentViewModel
            {
                DepartmentId = x.DepartmentId,
                EmployeeId = x.EmployeeId,
                EmployeeDisplayName = BuildDisplayNameForDepartmentManager(employees, x),
                DepartmentEmail = x.DepartmentEmail,
                Name = x.Name
            });
            return View(listOfDepartment);
        }


        // GET:
        // CREATE Department
        public ActionResult CreateDepartment()
        {
            var employees = _employeeService.GetAllEmployees();
            var model = new DepartmentViewModel
            {
                Employees = new List<SelectListItem>()
            };
            foreach (var item in employees)
            {
                model.Employees.Add(new SelectListItem
                {
                    Text = item.PersonalDetails.FirstName + " " + item.PersonalDetails.LastName,
                    Value = item.EmployeeId
                });
            }
            return View(model);
        }
        // POST:
        // CREATE Department

        [HttpPost]
        public ActionResult CreateDepartment(DepartmentViewModel department)
        {

            _departmentService.CreateDepartment(new Domain.Department
            {
                EmployeeId = department.EmployeeId,
                DepartmentEmail = department.DepartmentEmail,
                Name = department.Name
                
            });

            return RedirectToAction("ListDepartments");
        }

        //EDIT DEPARTMENT
        public ActionResult UpdateDepartment(string id)
        {
            var myDepartment = _departmentService.GetDepartmentById(id);
            var employees = _employeeService.GetAllEmployees();
            var departmentToUpdate = new DepartmentViewModel
            {
                DepartmentId = myDepartment.DepartmentId,
                Name = myDepartment.Name,
                DepartmentEmail = myDepartment.DepartmentEmail,
                EmployeeId = myDepartment.EmployeeId,
                Employees = new List<SelectListItem>()
            };

            foreach (var item in employees)
            {
                departmentToUpdate.Employees.Add(new SelectListItem
                {
                    Text = item.PersonalDetails.FirstName + " " + item.PersonalDetails.LastName,
                    Value = item.EmployeeId,
                    Selected = item.EmployeeId == myDepartment.EmployeeId
                });

            }
            
            return View(departmentToUpdate);
        }

        //EDIT DEPARTMENT
        [HttpPost]
        public ActionResult UpdateDepartment(DepartmentViewModel department)
        {
            var myDepartment = _departmentService.GetDepartmentById(department.DepartmentId);
            myDepartment.EmployeeId = department.EmployeeId;
            myDepartment.Name = department.Name;
            myDepartment.DepartmentEmail = department.DepartmentEmail;

            _departmentService.UpdateDepartment(myDepartment);
            return RedirectToAction("ListDepartments", new { id = department.DepartmentId });

        }

        //DELETE
        public ActionResult DeleteDepartment(string id)
        {
            var myDepartment = _departmentService.GetDepartmentById(id);
            var departmentToDelete = new DeleteDepartmentViewModel
            {
                DepartmentId = myDepartment.DepartmentId,
                Name = myDepartment.Name
            };
            return View(departmentToDelete);
        }

        //DELETE
        [HttpPost]
        public ActionResult DeleteDepartment(string id, FormCollection formcollection)
        {
            _departmentService.DeleteDepartment(id);
            return RedirectToAction("ListDepartments");
        }



        private string BuildDisplayNameForDepartmentManager(IList<Domain.Employee> employees, Domain.Department department)
        {
            var employee = employees.First(x => x.EmployeeId == department.EmployeeId);
            return employee.PersonalDetails.FirstName + " " + employee.PersonalDetails.LastName;
        }
    }
}