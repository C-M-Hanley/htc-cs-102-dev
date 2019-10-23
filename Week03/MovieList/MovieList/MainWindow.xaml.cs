using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Movie> Movies = new ObservableCollection<Movie>();
        public MainWindow()
        {
            InitializeComponent();
            lvMovies.ItemsSource = Movies;
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in Movies)
            {
                movie.ShowDetails();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string title = titleInput.Text;
            string director = directorInput.Text;

            DateTime releaseDate = DateTime.Now;
            if (Date.SelectedDate != null)
            {
                releaseDate = Date.SelectedDate.Value;
            }

            int length = 0;
            if(lengthInput.Text.Length > 0)
            {
                length = Convert.ToInt32(lengthInput.Text);
            }
            string genre = genreInput.Text;

            int rotten = 0;
            if (rottenInput.Text.Length > 0)
            {
                rotten = Convert.ToInt32(rottenInput.Text);
            }


            Movie movie = new Movie(title, releaseDate, director, length, genre, rotten);
            Movies.Add(movie);
            MessageBox.Show("Movie was added");
        }

        private void lvMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie = lvMovies.SelectedItem as Movie;
            if (selectedMovie != null)
            selectedMovie.ShowDetails();
        }
    }
}
