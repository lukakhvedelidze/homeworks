using System;

namespace homework9
{

    public class Doctor : Employee
    {
        public string Specialization { get; set; }
        public int ExaminedPatientsCount { get; set; } 

        public Doctor(string fullName, decimal salary, string specialization, int examinedPatientsCount)
            : base(fullName, salary)
        {
            Specialization = specialization;
            ExaminedPatientsCount = examinedPatientsCount;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"სპეციალობა: {Specialization}");
            Console.WriteLine($"გასინჯული პაციენტები: {ExaminedPatientsCount}");
        }

        public override void PerformDuty()
        {
            Console.WriteLine($"ექიმი {FullName} სინჯავს პაციენტს ({Specialization}).");
        }

        public override decimal CalculateBonus()
        {
            
            return ExaminedPatientsCount * 10;
        }
    }

    
    public class Nurse : Employee
    {
        public string Department { get; set; }
        public int CompletedShifts { get; set; } 

        public Nurse(string fullName, decimal salary, string department, int completedShifts)
            : base(fullName, salary)
        {
            Department = department;
            CompletedShifts = completedShifts;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"განყოფილება: {Department}");
            Console.WriteLine($"შესრულებული ცვლები: {CompletedShifts}");
        }

        public override void PerformDuty()
        {
            Console.WriteLine($"ექთანი {FullName} უწევს დახმარებას პაციენტებს ({Department} განყოფილება).");
        }

        public override decimal CalculateBonus()
        {
            
            return CompletedShifts * 25;
        }
    }

   
    public class Receptionist : Employee
    {
        public int RegisteredPatients { get; set; } 

        public Receptionist(string fullName, decimal salary, int registeredPatients)
            : base(fullName, salary)
        {
            RegisteredPatients = registeredPatients;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"რეგისტრირებული პაციენტები: {RegisteredPatients}");
        }

        public override void PerformDuty()
        {
            Console.WriteLine($"რეგისტრატორი {FullName} არეგისტრირებს ახალ პაციენტს.");
        }

        public override decimal CalculateBonus()
        {
           
            return RegisteredPatients * 5;
        }
    }
}
