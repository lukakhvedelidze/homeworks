using System;

namespace homework9
{
    public class Employee
    {
        private string fullName;
        private decimal salary;

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    fullName = value;
                else
                    fullName = "უცნობი თანამშრომელი";
            }
        }

        
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    salary = 0; 
            }
        }

        public Employee(string fullName, decimal salary)
        {
            FullName = fullName;
            Salary = salary;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"სახელი და გვარი: {FullName}");
            Console.WriteLine($"ხელფასი: {Salary} ლარი");
        }

       
        public virtual void PerformDuty()
        {
            Console.WriteLine($"{FullName} ასრულებს ზოგად მოვალეობას.");
        }

        public virtual decimal CalculateBonus()
        {
            return 0;
        }
    }
}