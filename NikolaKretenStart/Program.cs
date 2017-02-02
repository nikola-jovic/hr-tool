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
        private static readonly IList<Project> ProjectList = new List<Project>
        {
            new Project { ProjectName = "Manage Apps", IsActive = true},
            new Project { ProjectName = "Migration", IsActive = false},
            new Project { ProjectName = "TagMan", IsActive = false},
            new Project { ProjectName = "Flexiant", IsActive = false}
        };

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
                while (string.IsNullOrEmpty(empFirstName))
                {
                    _consoleWriter.WriteToConsole("Please enter a valid value for employee name!");
                    empFirstName = Console.ReadLine();
                }


                _consoleWriter.WriteToConsole("Enter last name of an employee: ");
                var empLastName = Console.ReadLine();
                while (string.IsNullOrEmpty(empLastName))
                {
                    _consoleWriter.WriteToConsole("Please enter a valid value for employee last name!");
                    empLastName = Console.ReadLine();
                }

                _consoleWriter.WriteToConsole("Enter age of an employee: ");
                var empAge = Console.ReadLine();

                _consoleWriter.WriteToConsole("Enter employee's departman: ");
                var empDepartman = Console.ReadLine();

                
                _consoleWriter.WriteToConsole(string.Format("Choose employee's project from a list below: \n 1. {0} \n 2. {1} \n 3. {2} \n 4. {3}", ProjectList[0].ProjectName, ProjectList[1].ProjectName, ProjectList[2].ProjectName, ProjectList[3].ProjectName));
                var enteredNumber = int.Parse(Console.ReadLine());

                var empSelectedProject = ProjectList[enteredNumber - 1];


                _consoleWriter.WriteToConsole("Enter role of an employee: ");
                var empRole = Console.ReadLine();

                var employee = new Employee(empFirstName, empLastName, int.Parse(empAge), (DepartmanType)Enum.Parse(typeof(DepartmanType), empDepartman), (RoleType)Enum.Parse(typeof(RoleType), empRole), empSelectedProject);


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
                            _consoleWriter.WriteToConsole(string.Format("Employee name is {0}, Last Name is {1}, age is {2}, his departman is {3} and his role is {4}. He is working on a {5} project", emp.FirstName, emp.LastName, emp.Age, emp.DepartmanType.GetDepartmanName(), emp.Role.GetRoleName(), empSelectedProject.ProjectName));

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

        }


    }


}
