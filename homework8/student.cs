using System;

namespace homework_student
{
    public class Student
    {
       
        private string name;
        private string surname;
        private int age;
        private string email;
        private string phone;
        private double gpa;
        private int course;
        private string university;
        private string faculty;
        private bool isBudget;

        
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 2)
                    name = value;
                else
                    name = "უცნობია";
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 2)
                    surname = value;
                else
                    surname = "უცნობია";
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 16 && value > 0)
                    age = value;
                else
                    age = 18; 
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Contains("@"))
                    email = value;
                else
                    email = "default@gmail.com";
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 9)
                    phone = value;
                else
                    phone = "500000000";
            }
        }

        public double GPA
        {
            get { return gpa; }
            set
            {
                if (value >= 0.0 && value <= 4.0)
                    gpa = value;
                else
                    gpa = 0.0;
            }
        }

        public int Course
        {
            get { return course; }
            set
            {
                if (value >= 1 && value <= 6)
                    course = value;
                else
                    course = 1;
            }
        }

        public string University
        {
            get { return university; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    university = value;
                else
                    university = "თავისუფალი უნივერსიტეტი";
            }
        }

        public string Faculty
        {
            get { return faculty; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    faculty = value;
                else
                    faculty = "ინფორმაციული ტექნოლოგიები";
            }
        }

        public bool IsBudget
        {
            get { return isBudget; }
            set { isBudget = value; }
        }

       
        public Student(string name, string surname, int age, string email, string phone, double gpa, int course, string university, string faculty, bool isBudget)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
            Phone = phone;
            GPA = gpa;
            Course = course;
            University = university;
            Faculty = faculty;
            IsBudget = isBudget;
        }

        
        public void PrintStudentInfo()
        {
            Console.WriteLine("=== სტუდენტის სრული ინფორმაცია ===");
            Console.WriteLine($"სახელი და გვარი: {Name} {Surname}");
            Console.WriteLine($"ასაკი: {Age}");
            Console.WriteLine($"ელ-ფოსტა: {Email}");
            Console.WriteLine($"ტელეფონი: {Phone}");
            Console.WriteLine($"GPA (შეფასება): {GPA}");
            Console.WriteLine($"კურსი: {Course}");
            Console.WriteLine($"უნივერსიტეტი: {University}");
            Console.WriteLine($"ფაკულტეტი: {Faculty}");
            Console.WriteLine($"ბიუჯეტურია: {(IsBudget ? "კი" : "არა")}");
            Console.WriteLine("====================================\n");
        }
    }
}