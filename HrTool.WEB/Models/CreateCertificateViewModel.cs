using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.WEB.Models
{
    public class CreateCertificateViewModel
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ValidFromDate { get; set; }
        public DateTime ValidToDate { get; set; }
        public bool IsPermanent { get; set; }
        public string URL { get; set; }
    }
}