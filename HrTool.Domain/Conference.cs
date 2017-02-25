using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    public class Conference
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Location { get; set; }
        public DateTime Started { get; private set; }
        public DateTime Completed { get; private set; }

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