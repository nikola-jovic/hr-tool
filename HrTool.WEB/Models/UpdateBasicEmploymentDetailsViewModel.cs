using HrTool.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HrTool.WEB.Models
{
    public class UpdateBasicEmploymentDetailsViewModel
    {
        public string EmployeeId { get; set; }
        public string DepartmentId { get; set; }
        public ContractType ContractType { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public string RecommendedByEmployee { get; set; }
        public string AccountNumber { get; set; }

        public IList<SelectListItem> Departments { get; set; }
    }
}