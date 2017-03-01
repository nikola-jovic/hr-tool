using HrTool.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.WEB.Models
{
    public class UpdateBasicEmploymentDetailsViewModel
    {
        public string EmployeeId { get; set; }
        public ContractType ContractType { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public string RecommendedByEmployee { get; set; }
        public string AccountNumber { get; set; }
    }
}