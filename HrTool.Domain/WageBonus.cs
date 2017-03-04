using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    public class WageBonus
    {
        public DateTime DateOfBonus { get; set; }
        public decimal BonusAmount { get; set; }
        public string Note { get; set; }

        public WageBonus()
        {

        }

        public WageBonus(DateTime dateOfBonus, decimal bonusAmount, string note)
        {
            DateOfBonus = dateOfBonus;
            BonusAmount = bonusAmount;
            Note = note;
        }
    }
}