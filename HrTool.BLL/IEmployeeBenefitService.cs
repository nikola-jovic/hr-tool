using HrTool.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrTool.BLL
{
    public interface IEmployeeBenefitService
    {
        IList<EmployeeBenefit> GetAllEmployeeBenefits();
        EmployeeBenefit GetEmployeeBenefitById(string employeeBenefitId);
        void CreateEmployeeBenefit(EmployeeBenefit employeeBenefitToCreate);
        void DeleteEmployeeBenefit(string employeeBenefitId);
        void UpdateEmployeeBenefit(EmployeeBenefit employeeBenefitToUpdate);
    }
}
