using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrTool.WEB.Models
{
    public class UpdateWageChangeDetailsModelView
    {
        public DateTime DateOfChange { get; set; }
        public bool IsDecrease { get; set; }
        public decimal ChangeAmount { get; set; }
    }
}