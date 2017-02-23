using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Tool.Core
{
    public class Training
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime Started { get; private set; }
        public DateTime Completed { get; private set; }

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