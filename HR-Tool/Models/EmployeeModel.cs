using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace HR_Tool.Models
{
    public class EmployeeBenefit
    {
        public Guid EmployeeBenefitId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public EmployeeBenefit(Guid employeeBenefitId, string name, string description)
        {
            EmployeeBenefitId = employeeBenefitId;
            Name = name;
            Description = description;
        }
    }

    public class Training
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime Started { get; private set; }
        public DateTime Completed { get; private set; }

        public Training(string name, string description, DateTime started, DateTime completed)
        {
            Name = name;
            Description = description;
            Started = started;
            Completed = completed;
        }
    }

    public class Conference
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Location { get; set; }
        public DateTime Started { get; private set; }
        public DateTime Completed { get; private set; }

        public Conference(string name, string description, string location, DateTime started, DateTime completed)
        {
            Name = name;
            Description = description;
            Location = location;
            Started = started;
            Completed = completed;
        }
    }

    public class Certificate
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime ValidFromDate { get; set; }
        public DateTime ValidToDate { get; set; }
        public bool IsPermanent { get; set; }
        public string URL { get; set; }

        public Certificate(string name, string description, DateTime validFromDate, DateTime validToDate, bool isPermanent, string url)
        {
            Name = name;
            Description = description;
            ValidFromDate = validFromDate;
            ValidToDate = validToDate;
            IsPermanent = isPermanent;
            URL = url;
        }
    }

    public class Education
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime FromDate { get; private set; }
        public DateTime ToDate { get; private set; }
       

        public Education(string name, string description, DateTime fromDate, DateTime toDate)
        {
            Name = name;
            Description = description;
            FromDate = fromDate;
            ToDate = toDate;
        }
    }

    public class Wage
    {
        public decimal CurrentWage { get; private set; }
        public decimal InitialWage { get; private set; }
        public IList<WageChange> WageChanges { get; set; }

        public Wage(decimal currentWage, decimal initialWage, IList<WageChange> wageChanges)
        {
            CurrentWage = currentWage;
            InitialWage = initialWage;
            WageChanges = wageChanges;
        }
    }

    public class WageChange
    {
        public DateTime DateOfChange { get; private set; }
        public bool IsDecrease { get; private set; }
        public decimal ChangeAmount { get; private set; }

        public WageChange(DateTime dateOfChange, bool isDecrease, decimal changeAmount)
        {
            DateOfChange = dateOfChange;
            IsDecrease = isDecrease;
            ChangeAmount = changeAmount;
        }
    }

    public class WageBonus
    {
        public DateTime DateOfBonus { get; private set; }
        public decimal BonusAmount { get; private set; }

        public WageBonus(DateTime dateOfBonus, decimal bonusAmount)
        {
            DateOfBonus = dateOfBonus;
            BonusAmount = bonusAmount;
        }
    }

    public enum MaritalStatus
    {
        Married = 0,
        Single = 1,
        Divorced = 2,
        Widowed = 3,
        Engaged = 4,
        InRelationship = 5

    }

    public enum ContractType
    {
        FullTime = 0,
        PartTime = 1,
        FixedTerm = 2,
        Contractor = 3,
        Consultant = 4,
        OnCallWork = 5,
        Internship = 6

    }
    public enum EmploymentType
    {
        LinkedIn = 0,
        Recommendation = 1,
        JobAd = 2, 
        Other = 3
    }

    [BsonIgnoreExtraElements]
    public class EmployeeModel
    {
        //for now, everything is declared as strings, for simplicity
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UMCN { get; set; }
        public string MobPhoneNum { get; set; }
        public string HomePhoneNum { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public MaritalStatus MaritatStatus { get; set; }
        // ^ personal details

        
        public ContractType ContractType { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public string RecommendedByEmployee { get; set; } /* why */
        public string AccountNumber { get; set; }
        public Wage Wage { get; set; }

        public IList<EmployeeBenefit> Benefits { get; set; }
        public IList<Training> Trainings { get; set; }
        public IList<Conference> Conferences { get; set; }
        public IList<Certificate> Certificates { get; set; }
        public IList<Education> Education { get; set; }
        public IList<WageBonus> WageBonuses { get; set; }
        // ^ employment details
    }
}