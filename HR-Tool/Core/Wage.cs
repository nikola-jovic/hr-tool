using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Tool.Core
{
    public class Wage
    {
        public decimal CurrentWage { get; private set; }
        public decimal InitialWage { get; private set; }
        public IList<WageChange> WageChanges { get; set; }

        public Wage()
        {

        }

        public Wage(decimal currentWage, decimal initialWage, IList<WageChange> wageChanges)
        {
            CurrentWage = currentWage;
            InitialWage = initialWage;
            WageChanges = wageChanges;
        }
    }
}