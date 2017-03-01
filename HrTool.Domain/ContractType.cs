using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    public enum ContractType
    {
        [Display(Name = "Full Time")]
        FullTime = 0,
        [Display(Name = "Part Time")]
        PartTime = 1,
        [Display(Name = "Fixed Term")]
        FixedTerm = 2,
        [Display(Name = "Contractor")]
        Contractor = 3,
        [Display(Name = "Consultant")]
        Consultant = 4,
        [Display(Name = "On-Call Work")]
        OnCallWork = 5,
        [Display(Name = "Internship")]
        Internship = 6

    }
}