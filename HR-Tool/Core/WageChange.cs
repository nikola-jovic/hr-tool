using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Tool.Core
{
    public class WageChange
    {
        public DateTime DateOfChange { get; private set; }
        public bool IsDecrease { get; private set; }
        public decimal ChangeAmount { get; private set; }

        public WageChange()
        {

        }
        public WageChange(DateTime dateOfChange, bool isDecrease, decimal changeAmount)
        {
            DateOfChange = dateOfChange;
            IsDecrease = isDecrease;
            ChangeAmount = changeAmount;
        }
    }
}