using System;

namespace Employees
{
    public abstract partial class Employee
    {
        // Field data.
        protected string EmpName;
        protected int EmpId;
        protected float CurrPay;
        protected int EmpAge;
        protected string EmpSsn;
        protected EmployeePayTypeEnum EmpPayType;
        protected BenefitPackageInner EmpBenefits = new BenefitPackageInner();
        
        // Using properties
        public string Name
        {
            get { return EmpName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    EmpName = value;
                }
            }
        }

        public int Id
        {
            get => EmpId;
            set => EmpId = value;
        }

        public float Pay
        {
            get => CurrPay;
            set => CurrPay = value;
        }
        
        public int Age
        {
            get => EmpAge;
            set => EmpAge = value;
        }

        public string SocialSecurityNumber
        {
            get => EmpSsn;
            private set => EmpSsn = value;
        }

        public EmployeePayTypeEnum PayType
        {
            get => EmpPayType;
            set => EmpPayType = value;
        }

        public double GetBenefitCost() => EmpBenefits.ComputePayDeduction();

        public BenefitPackageInner Benefits
        {
            get => EmpBenefits;
            set => EmpBenefits = value;
        }
        
        public class BenefitPackageInner
        {
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }
            // Assume we have other members that represent
            // dental/health benefits, and so on.
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
    }
}