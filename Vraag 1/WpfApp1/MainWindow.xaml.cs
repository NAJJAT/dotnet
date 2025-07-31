using ClassLibrary1;
using ClassLibrary1.DTO;
using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private IEnumerable<Movie> movies = [];

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_LoadMovie(object sender, RoutedEventArgs e)
        {
            btnload.IsEnabled = false;

            // Get all JSON files
            var fetchMovies = new MovieFatcher();
            fetchMovies.MovieFetched += async (_, count) => await Dispatcher.InvokeAsync(() => prograsBar.Value = count);

            this.movies = await fetchMovies.FetchMoviesAsync();

            // Update textResult.Text after movies are fully loaded and sorted
            btnload.IsEnabled = true;
            prograsBar.Value = 50_000;

        }


        private void Button_Search(object sender, RoutedEventArgs e)
        {
            var searchTerm = textboxsearch.Text;
            try
            {
                var searchResult = new MovieFatcher().FilterMovies(this.movies, searchTerm);
                textResult.Text = string.Join(Environment.NewLine, searchResult);
            }
            catch (InvalidInputException ex)
            {
                textResult.Text = ex.Message;

            }

        }
    }
}
