using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrTool.Domain;
using HrTool.DAL;

namespace HrTool.BLL
{
    public class EmployeeBenefitService : IEmployeeBenefitService
    {
        private readonly IRepository _repository;

        public EmployeeBenefitService()
        {
            _repository = new Repository();
        }
        public void CreateEmployeeBenefit(EmployeeBenefit employeeBenefitToCreate)
        {
            employeeBenefitToCreate.EmployeeBenefitId = Guid.NewGuid().ToString();
            _repository.CreateEmployeeBenefit(employeeBenefitToCreate);
        }

        public void DeleteEmployeeBenefit(string employeeBenefitId)
        {
            _repository.DeleteEmployeeBenefit(employeeBenefitId);
        }

        public IList<EmployeeBenefit> GetAllEmployeeBenefits()
        {
            return _repository.GetAllEmployeeBenefits();
        }

        public EmployeeBenefit GetEmployeeBenefitById(string employeeBenefitId)
        {
            return _repository.GetEmployeeBenefitById(employeeBenefitId);
        }

        public void UpdateEmployeeBenefit(EmployeeBenefit employeeBenefitToUpdate)
        {
            _repository.UpdateEmployeeBenefit(employeeBenefitToUpdate);
        }
    }
}
