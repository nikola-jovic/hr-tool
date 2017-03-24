﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    [BsonIgnoreExtraElements]
    public class EmployeeBenefit
    {
        public string EmployeeBenefitId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}