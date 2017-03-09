using HrTool.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HrTool.WEB.Models
{
    public class DepartmentViewModel
    {
        public string DepartmentId { get; set; }
        [DisplayName("Department Manager")]
        public string EmployeeId { get; set; }
        public string EmployeeDisplayName { get; set; }
        public string Name { get; set; }
        public string DepartmentEmail { get; set; }

        public IList<SelectListItem> Employees { get; set; }
        
    }
}