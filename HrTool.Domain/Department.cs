using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrTool.Domain
{
    [BsonIgnoreExtraElements]
    public class Department
    {
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string DepartmentEmail { get; set; }

    }
}
