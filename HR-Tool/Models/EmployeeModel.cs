using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using HR_Tool.Core;

namespace HR_Tool.Models
{
    [BsonIgnoreExtraElements]
    public class EmployeeModel
    {
        public PersonalDetails PersonalDetails { get; set; }
        public EmploymentDetails EmploymentDetails { get; set; }
    }
}