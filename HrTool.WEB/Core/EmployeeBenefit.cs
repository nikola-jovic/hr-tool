using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Tool.Core
{
    public class EmployeeBenefit
    {
        public Guid EmployeeBenefitId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public EmployeeBenefit()
        {

        }
        public EmployeeBenefit(Guid employeeBenefitId, string name, string description)
        {
            EmployeeBenefitId = employeeBenefitId;
            Name = name;
            Description = description;
        }
    }
}