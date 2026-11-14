using System;

namespace homeworks
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

       
        public Student(string name, string surname, int age, int grade)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Grade = grade;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"student: {Name} {Surname}, age: {Age}, grade: {Grade}");
        }

        
        public override bool Equals(object obj)
        {
            if (obj is Student other)
            {
                return Name == other.Name && Surname == other.Surname && Age == other.Age && Grade == other.Grade;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Surname, Age, Grade);
        }
    }
}