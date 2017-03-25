using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HrTool.WEB.Models
{
    public class ManageEmployeeBenefitViewModel
    {
        public string EmployeeId { get; set; }
        public string EmployeeBenefitId { get; set; }
        public IList<Domain.EmployeeBenefit> AvailableBenefits { get; set; }
        public IList<string> SelectedBenefitIds { get; set; }
    }
}