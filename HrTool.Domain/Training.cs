using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    public class Training
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Started { get; set; }
        public DateTime Completed { get; set; }

        public Training()
        {

        }

        public Training(string name, string description, DateTime started, DateTime completed)
        {
            Name = name;
            Description = description;
            Started = started;
            Completed = completed;
        }
    }
}