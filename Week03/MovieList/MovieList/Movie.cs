using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
   public class Movie
    {
        public string Title { get; set;}
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }
        public double Rotten { get; set; }

        public Movie(string title, DateTime releaseDate)
        {
            Title = title;
            ReleaseDate = releaseDate;
        }

        public Movie(string title, DateTime releaseDate, string director)
        {
            Title = title;
            ReleaseDate = releaseDate;
            Director = director;
        }

        public Movie(string title, DateTime releaseDate, string director, int length)
        {
            Title = title;
            ReleaseDate = releaseDate;
            Director = director;
            Length = length;
        }

        public Movie(string title, DateTime releaseDate, string director, int length, string genre)
        {
            Title = title;
            ReleaseDate = releaseDate;
            Director = director;
            Length = length;
            Genre = genre;
        }

        public Movie(string title, DateTime releaseDate, string director, int length, string genre, double rotten)
        {
            Title = title;
            ReleaseDate = releaseDate;
            Director = director;
            Length = length;
            Genre = genre;
            Rotten = rotten;
        }

        public void ShowDetails()
        {
            MessageBox.Show(Title + " was released in " + ReleaseDate + "\n\r" + "Director is " + Director + "\n\r" + "Length is " + Length + "\n\r" + "Genre is " + Genre + "\n\r" + "Rotten Tomatoes Score is " + Rotten);
        }
    }
}
