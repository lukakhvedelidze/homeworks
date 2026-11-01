using System;

namespace homework_student
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student myStudent = new Student(
                name: "ლუკა",
                surname: "ხვედელიძე",
                age: 20,
                email: "luka.khvedelidze@gmail.com",
                phone: "599123456",
                gpa: 3.8,
                course: 2,
                university: "საქართველოს უნივერსიტეტი",
                faculty: "კომპიუტერული მეცნიერებები",
                isBudget: true
            );

            
            myStudent.PrintStudentInfo();
        }
    }
}
