using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    public class EmploymentDetails
    {
        public ContractType ContractType { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public string RecommendedByEmployee { get; set; } /* why */
        public string AccountNumber { get; set; }
        public Wage Wage { get; set; }

        public IList<EmployeeBenefit> Benefits { get; set; }
        public IList<Training> Trainings { get; set; }
        public IList<Conference> Conferences { get; set; }
        public IList<Certificate> Certificates { get; set; }
        public IList<Education> Education { get; set; }
        public IList<WageBonus> WageBonuses { get; set; }
    }
}