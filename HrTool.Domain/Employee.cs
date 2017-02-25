using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrTool.Domain
{
    [BsonIgnoreExtraElements]
    public class Employee
    {
        public string EmployeeId { get; set; }
        public PersonalDetails PersonalDetails { get; set; }
        public EmploymentDetails EmploymentDetails { get; set; }
    }
}
