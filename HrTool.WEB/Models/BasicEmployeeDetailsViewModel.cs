using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using HrTool.Domain;

namespace HrTool.WEB.Models
{
    public class BasicEmployeeDetailsViewModel
    {
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobPhoneNumber { get; set; }
        public string Address { get; set; }
    }
}