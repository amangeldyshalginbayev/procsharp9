using System;

namespace EmployeeApp
{
    class Employee
    {
        // Field data.
        private string _empName;
        private int _empId;
        private float _currPay;
        private int _empAge;
        private string _empSSN;
        private EmployeePayTypeEnum _payType;
        
        // Constructors.
        public Employee()
        {
        }

        public Employee(string name, int id, float pay, string empSsn) : this(name, id, pay, 0, empSsn,EmployeePayTypeEnum.Salaried)
        {
        }

        public Employee(string empName, int empId, float currPay, int empAge, string empSsn, EmployeePayTypeEnum payType)
        {
            // _empName = empName;
            // _empId = empId;
            // _currPay = currPay;
            // _empAge = empAge;
            Name = empName;
            Id = empId;
            Pay = currPay;
            Age = empAge;
            SocialSecurityNumber = empSsn;
            PayType = payType;
        }

        // Methods.
        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commission } => Pay += .10f * amount,
                { PayType: EmployeePayTypeEnum.Hourly } => Pay += 40f * amount / 2080f,
                { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
                _ => Pay += 0
            };
        }//=> Pay += amount;//_currPay += amount;

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
            Console.WriteLine("PayType: {0}", PayType);
        }

        // public string GetName() => _empName;
        //
        // public void SetName(string name)
        // {
        //     if ((bool?)(name?.Length > 15) ?? true)
        //     {
        //         Console.WriteLine("Error! Name length exceeds 15 characters OR null!");
        //     }
        //     else
        //     {
        //         _empName = name;
        //     }
        // }

        // Using properties
        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }

        public int Id
        {
            get => _empId;
            set => _empId = value;
        }

        public float Pay
        {
            get => _currPay;
            set => _currPay = value;
        }
        
        public int Age
        {
            get => _empAge;
            set => _empAge = value;
        }

        public string SocialSecurityNumber
        {
            get => _empSSN;
            private set => _empSSN = value;
        }

        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }
    }
}