using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    public class Education
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public Education() { }

        public Education(string name, string description, DateTime fromDate, DateTime toDate)
        {
            Name = name;
            Description = description;
            FromDate = fromDate;
            ToDate = toDate;
        }
    }
}