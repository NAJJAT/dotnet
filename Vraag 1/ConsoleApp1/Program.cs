using ClassLibrary1;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        static async void Main(string[] args)
        {


            LoadMovies().Wait();

        }

        public static async Task LoadMovies()
        {
            Console.WriteLine("Start Loading.....");
            var fetchMovies = new MovieFatcher();
            var movies = await fetchMovies.FetchMoviesAsync();
            Console.WriteLine("Screah:");
            var searchTerm = Console.ReadLine();

            try
            {

                var searchResult = fetchMovies.FilterMovies(movies, searchTerm);
                foreach (var movie in searchResult)
                {
                    Console.WriteLine(movie);
                }
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}