using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    public class Conference
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime Started { get; set; }
        public DateTime Completed { get; set; }

        public Conference()
        {

        }

        public Conference(string name, string description, string location, DateTime started, DateTime completed)
        {
            Name = name;
            Description = description;
            Location = location;
            Started = started;
            Completed = completed;
        }
    }
}