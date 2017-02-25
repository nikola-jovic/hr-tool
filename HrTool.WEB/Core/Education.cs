using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Tool.Core
{
    public class Education
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime FromDate { get; private set; }
        public DateTime ToDate { get; private set; }

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