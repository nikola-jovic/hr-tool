using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Tool.Models
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UMCN { get; set; }
        public string MobPhoneNum { get; set; }
        public string HomePhoneNum { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}