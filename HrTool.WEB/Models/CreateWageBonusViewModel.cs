﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HrTool.WEB.Models
{
    public class CreateWageBonusViewModel
    {
        public string EmployeeId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBonus { get; set; }
        public decimal BonusAmount { get; set; }
        public string Note { get; set; }
    }
}