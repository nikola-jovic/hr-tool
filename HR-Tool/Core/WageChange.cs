using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Tool.Core
{
    public class WageChange
    {
        public DateTime DateOfChange { get; set; }
        public bool IsDecrease { get; set; }
        public decimal ChangeAmount { get; set; }

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