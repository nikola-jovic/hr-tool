using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.WEB.Models
{
    public class CreateConferenceViewModel
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime Started { get; set; }
        public DateTime Completed { get; set; }
    }
}