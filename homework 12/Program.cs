using System;
using System.Linq;

namespace homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Student[] students = new Student[]
            {
                new Student("luka", "khvedelidze", 20, 85),
                new Student("nino", "beridze", 19, 92),
                new Student("giorgi", "maisuradze", 21, 78),
                new Student("nino", "beridze", 19, 92), 
                new Student("ana", "gelashvili", 20, 88)
            };

            Console.WriteLine("=== first array ===");
            foreach (var s in students)
            {
                s.PrintInfo();
            }

            
            var sortedStudents = students.OrderBy(s => s.Grade).ToArray();

            Console.WriteLine("\n=== sorted array (according to grades) ===");
            foreach (var s in sortedStudents)
            {
                s.PrintInfo();
            }

            
            Console.WriteLine("\n=== dublicate students ===");
            bool foundDuplicate = false;

            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i].Equals(students[j]))
                    {
                        Console.Write($"dublicate found: ");
                        students[i].PrintInfo();
                        foundDuplicate = true;
                    }
                }
            }

            if (!foundDuplicate)
            {
                Console.WriteLine("dublicated object not find");
            }


            Movie[] movies = new Movie[]
            {
                new Movie("Inception", 2010),
                new Movie("Interstellar", 2014),
                new Movie("Avatar", 2009),
                new Movie("Inception", 2010), 
                new Movie("The Godfather", 1972)
            };

            Console.WriteLine("=== first film array ===");
            foreach (var m in movies)
            {
                m.PrintInfo();
            }

            
            var sortedMovies = movies.OrderBy(m => m.ReleaseYear).ToArray();

            Console.WriteLine("\n=== sorted films (according to release year) ===");
            foreach (var m in sortedMovies)
            {
                m.PrintInfo();
            }

            
            Console.WriteLine("\n=== dublicated movies ===");
            bool foundDuplicate = false;

            for (int i = 0; i < movies.Length; i++)
            {
                for (int j = i + 1; j < movies.Length; j++)
                {
                    if (movies[i].Equals(movies[j]))
                    {
                        Console.Write($"dublicate found: ");
                        movies[i].PrintInfo();
                        foundDuplicate = true;
                    }
                }
            }

            if (!foundDuplicate)
            {
                Console.WriteLine("dublicated object not found.");
            }
        }
    }
}
