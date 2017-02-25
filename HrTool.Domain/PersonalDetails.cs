using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HrTool.Domain
{
    public class PersonalDetails
    {
        //for now, everything is declared as strings, for simplicity
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        public string UMCN { get; set; }
        public string MobPhoneNum { get; set; }
        public string HomePhoneNum { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public MaritalStatus MaritatStatus { get; set; }
    }
}