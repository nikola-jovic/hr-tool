using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikolaKretenStart
{

    public enum RoleType
    {
        CTO,
        COO,
        CEO,
        CopyPaste,
        Developer
    }

    public enum DepartmanType
    {
        JS,
        PHP,
        DNET,
        Internal,
        QA,
        HR
    }

    public class Employee : BaseEmployee
    {
        public DepartmanType DepartmanType { get; set; }
        public RoleType Role { get; set; }
        public Project Project { get; set; }

        public Employee(string firstName, string lastName, int age, DepartmanType departman, RoleType role, Project project)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DepartmanType = departman;
            Role = role;
            Project = project;
        }

        //public override string ToString()
        //{
        //    return string.Format("employee is {0} ( last name {1}, age - {2}, role {3})", FirstName, LastName, Age, Role);
        //}
    }
}
