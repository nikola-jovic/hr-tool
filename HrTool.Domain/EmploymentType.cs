using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    public enum EmploymentType
    {
        [Display(Name = "LinkedIn")]
        LinkedIn = 0,
        [Display(Name = "Recommendation")]
        Recommendation = 1,
        [Display(Name = "Job Ad")]
        JobAd = 2,
        [Display(Name = "Other")]
        Other = 3
    }
}