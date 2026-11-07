using System;

namespace homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Doctor doctor = new Doctor("გიორგი ბერიძე", 2500m, "კარდიოლოგი", 45);

            
            Nurse nurse = new Nurse("ნინო მამულაძე", 1400m, "რეანიმაცია", 12);

            
            Receptionist receptionist = new Receptionist("დავით კაპანაძე", 1000m, 120);

            
            Console.WriteLine("=== ექიმის ინფორმაცია ===");
            doctor.ShowInfo();
            doctor.PerformDuty();
            Console.WriteLine($"ბონუსი: {doctor.CalculateBonus()} ლარი\n");

            Console.WriteLine("=== ექთნის ინფორმაცია ===");
            nurse.ShowInfo();
            nurse.PerformDuty();
            Console.WriteLine($"ბონუსი: {nurse.CalculateBonus()} ლარი\n");

            Console.WriteLine("=== რეგისტრატორის ინფორმაცია ===");
            receptionist.ShowInfo();
            receptionist.PerformDuty();
            Console.WriteLine($"ბონუსი: {receptionist.CalculateBonus()} ლარი");
        }
    }
}
