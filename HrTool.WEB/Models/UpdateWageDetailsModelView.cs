using HrTool.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.WEB.Models
{
    public class UpdateWageDetailsModelView
    {
        public string EmployeeId { get; set; }
        public decimal CurrentWage { get; set; }
        public decimal InitialWage { get; set; }
        public IList<UpdateWageChangeDetailsModelView> WageChanges { get; set; }

    }
}