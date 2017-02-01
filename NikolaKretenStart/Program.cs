using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikolaKretenStart
{
    class Program
    {
        private static readonly IWriter _consoleWriter;
        static Program()
        {
            _consoleWriter = new ConsoleWriter();
        }

        static void Main(string[] args)
        {
            _consoleWriter.WriteToConsole("Enter name of the company: ");
            var companyName = Console.ReadLine();

            var company = new Company() { Name = companyName };
            company.EmployeeList = new List<Employee>();

            while (true)
            {
                _consoleWriter.WriteToConsole("Enter first name of an employee: ");
                var empFirstName = Console.ReadLine();

                _consoleWriter.WriteToConsole("Enter last name of an employee: ");
                var empLastName = Console.ReadLine();

                _consoleWriter.WriteToConsole("Enter age of an employee: ");
                var empAge = Console.ReadLine();

                _consoleWriter.WriteToConsole("Enter role of an employee: ");
                var empRole = Console.ReadLine();

                var employee = new Employee(empFirstName, empLastName, int.Parse(empAge), (RoleType)Enum.Parse(typeof(RoleType), empRole));


                company.EmployeeList.Add(employee);

                _consoleWriter.WriteToConsole("Do you want to add another employee? Y/N");

                var result = Console.ReadLine();

                if (result == "Y")
                {
                    continue;
                }
                else if (result == "N")
                {
                    _consoleWriter.WriteToConsole("Do you want to list all employees of the company? Y/N");
                    var decision = Console.ReadLine();
                    if (decision == "Y")
                    {
                        foreach (var emp in company.EmployeeList)
                        {
                            _consoleWriter.WriteToConsole(String.Format("Employee name is {0}, Last Name is {1}, age is {2} and his role is {3}", emp.FirstName, emp.LastName, emp.Age, emp.Role.GetRoleName()));

                        }
                        break;
                    }
                    else if (decision == "N")
                    {
                        _consoleWriter.WriteToConsole("Thank you!");
                        break;
                    }
                    else
                    {
                        _consoleWriter.WriteToConsole("Invalid Entry!");
                        break;
                    }

                }
                else
                {
                    _consoleWriter.WriteToConsole("Invalid Entry!");
                    break;
                }
            }
            //var employee1 = new Employee("Milan", "Stojanovic", 25, RoleType.CEO);
            //var employee2 = new Employee("Nikola", "Jovic", 25, RoleType.COO);
            //var employee3 = new Employee("Petar", "Jerinic", 25, RoleType.CopyPaste);

            //_consoleWriter.WriteToConsole("employee 1 role is {0}", GetRoleName(employee1.Role));
        }

        //private static string GetRoleName(RoleType roleType)
        //{
        //    switch (roleType)
        //    {
        //        case RoleType.CTO:
        //            return "CTO";
        //        case RoleType.COO:
        //            return "COO";
        //        case RoleType.CEO:
        //            return "CEO";
        //        case RoleType.CopyPaste:
        //            return "Copy-Paste";
        //        default:
        //            return "unknown role";

        //    }
        //}
    }

    public static class ExtensionMethods
    {
        public static string GetRoleName(this RoleType roleType)
        {
            switch (roleType)
            {
                case RoleType.CTO:
                    return "CTO";
                case RoleType.COO:
                    return "COO";
                case RoleType.CEO:
                    return "CEO";
                case RoleType.CopyPaste:
                    return "Copy-Paste";
                case RoleType.Developer:
                    return "Software Developer";
                default:
                    return "unknown role";

            }
        }
    }
}
