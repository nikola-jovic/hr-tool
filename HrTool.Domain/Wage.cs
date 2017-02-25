using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    public class Wage
    {
        public decimal CurrentWage { get; private set; }
        public decimal InitialWage { get; private set; }

        //public WageChange WageChange { get; set; }
        public IList<WageChange> WageChanges { get; set; }

        public Wage()
        {

        }

        public Wage(decimal initialWage, decimal currentWage, IList<WageChange> wageChanges)
        {
            InitialWage = initialWage;
            CurrentWage = currentWage;
            WageChanges = wageChanges;
        }
    }
}