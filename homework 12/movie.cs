using System;

namespace homeworks
{
    public class Movie
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }

        
        public Movie(string title, int releaseYear)
        {
            Title = title;
            ReleaseYear = releaseYear;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"movie: '{Title}', realease year: {ReleaseYear}");
        }

        
        public override bool Equals(object obj)
        {
            if (obj is Movie other)
            {
                return Title == other.Title && ReleaseYear == other.ReleaseYear;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, ReleaseYear);
        }
    }
}
