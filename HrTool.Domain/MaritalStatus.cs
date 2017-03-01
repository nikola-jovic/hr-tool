using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    public enum MaritalStatus
    {
        [Display(Name = "Married")]
        Married = 0,
        [Display(Name = "Single")]
        Single = 1,
        [Display(Name = "Divorced")]
        Divorced = 2,
        [Display(Name = "Widowed")]
        Widowed = 3,
        [Display(Name = "Engaged")]
        Engaged = 4,
        [Display(Name = "In Relationship")]
        InRelationship = 5

    }
}