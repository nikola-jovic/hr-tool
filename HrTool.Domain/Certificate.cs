using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    public class Certificate
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ValidFromDate { get; set; }
        public DateTime ValidToDate { get; set; }
        public bool IsPermanent { get; set; }
        public string URL { get; set; }

        public Certificate()
        {

        }

        public Certificate(string name, string description, DateTime validFromDate, DateTime validToDate, bool isPermanent, string url)
        {
            Name = name;
            Description = description;
            ValidFromDate = validFromDate;
            ValidToDate = validToDate;
            IsPermanent = isPermanent;
            URL = url;
        }
    }
}