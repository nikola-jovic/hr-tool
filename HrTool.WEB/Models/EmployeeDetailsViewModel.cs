using HrTool.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.WEB.Models
{
    public class EmployeeDetailsViewModel
    {
        public string EmployeeId { get; set; }
        public PersonalDetails PersonalDetails { get; set; }
        public EmploymentDetails EmploymentDetails { get; set; }
    }
}