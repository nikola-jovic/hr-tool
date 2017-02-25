﻿using HrTool.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrTool.DAL
{
    public interface IRepository
    {
        IList<Employee> GetAllEmployees();
        Employee GetEmployeeById(string employeeId);
        void CreateEmployee(Employee employeeToCreate);
        void DeleteEmployee(string employeeId);
        void UpdateEmployee(Employee employeeToUpdate);
    }
}
