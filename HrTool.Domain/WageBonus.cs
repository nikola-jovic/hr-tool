using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    public class WageBonus
    {
        public DateTime DateOfBonus { get; private set; }
        public decimal BonusAmount { get; private set; }

        public WageBonus()
        {

        }

        public WageBonus(DateTime dateOfBonus, decimal bonusAmount)
        {
            DateOfBonus = dateOfBonus;
            BonusAmount = bonusAmount;
        }
    }
}