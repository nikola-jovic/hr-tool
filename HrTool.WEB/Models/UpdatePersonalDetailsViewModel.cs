using HrTool.Domain;

namespace HrTool.WEB.Models
{
    public class UpdatePersonalDetailsViewModel
    {
        public string EmployeeId { get; set; }
        public PersonalDetails PersonalDetails { get; set; }
    }
}