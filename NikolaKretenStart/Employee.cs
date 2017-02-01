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

    public class Employee : BaseEmployee
    {        
        public RoleType Role { get; set; }

        public Employee(string firstName, string lastName, int age, RoleType role)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Role = role;
        }

        //public override string ToString()
        //{
        //    return string.Format("employee is {0} ( last name {1}, age - {2}, role {3})", FirstName, LastName, Age, Role);
        //}
    }
}
