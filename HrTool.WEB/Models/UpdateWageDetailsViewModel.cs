using HrTool.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.WEB.Models
{
    public class UpdateWageDetailsViewModel
    {
        public string EmployeeId { get; set; }
        public decimal CurrentWage { get; set; }
        public decimal InitialWage { get; set; }
        public IList<WageChange> WageChanges { get; set; }

    }
}